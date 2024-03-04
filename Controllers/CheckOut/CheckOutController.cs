using Microsoft.AspNetCore.Mvc;
using Nop.RestApi.Service.Controllers.Core;
using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.ApiUser;
using Nop.RestApi.Service.Models.Catalogue;
using Nop.RestApi.Service.Models.CheckOut;
using Nop.RestApi.Service.Services.Catalogue;
using Nop.RestApi.Service.Services.Core;
using Nop.RestApi.Service.Services.CustomerServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nop.RestApi.Service.Controllers.CheckOut
{
    public class CheckOutController : BaseAuthController
    {
        #region fields
        private readonly ICustomerService _customerService;
        private readonly IProductService _productservice;
        private readonly IApiMessageService _apimessageservice;
        #endregion fields

        #region ctor
        public CheckOutController(ICustomerService customerService, IProductService productService, IApiMessageService apiMessageService)
        {
            _customerService = customerService;
            _productservice = productService;
            _apimessageservice = apiMessageService;
        }
        #endregion ctor
        //get list of payment methods
        [HttpGet]
        [Route("Paymentmethods")]
        public virtual ActionResult Listpaymethod()
        {

            List<ApiPayments> paymethods = new()
            {
                new ApiPayments{ Id = 1, PaymentMode = "pay now", CardTypeIcon = "https://habahabamall.com/icons/icons_0/flutter.png"},
                new ApiPayments{ Id = 2, PaymentMode = "pay on delivery", CardTypeIcon = "https://habahabamall.com/icons/icons_0/cashondelivery.jpg"}
            };
            return Ok(paymethods);

        }

        //get  customer shipping address
        [HttpPost]
        [Route("Getshippingaddress")]
        public virtual ActionResult<IList<ApiAddress>> GetAddressByUserid(ApiCustomer customer)
        {
            if (customer.Userid <= 0)
            {
                return BadRequest("userid cannot be blank");
            }

            IList<ApiAddress> address = _customerService.GetAddressByUserid(customer.Userid);
            return Ok(address);

        }

        //get list all countries for selection in address
        [HttpGet]
        [Route("listcountries")]
        public virtual ActionResult<ApiAddress> GetCountries()
        {
            IList<ApiAddress> countrylist = _customerService.GetCountries();
            return Ok(countrylist);
        }

        [HttpGet]
        [Route("listprovices")]
        public virtual ActionResult<ApiAddress> GetProvinces()
        {
            IList<ApiAddress> countrylist = _customerService.GetStateProvinces();
            return Ok(countrylist);
        }

        //get customer ordered items
        [HttpPost]
        [Route("myorders")]
        public virtual ActionResult<IList<ApiProduct>> GetOrderItem(ApiCustomer customer)
        {
            if (customer.Userid > 0)
            {
                IList<ApiProduct> prod = _customerService.GetOrderedItems(customer.Userid);
                return Ok(prod);
            }
            return BadRequest();
        }

        //add user address
        [HttpPost]
        [Route("addaddress")]
        public virtual ActionResult AddUserAddress(ApiAddress apiAddress)
        {

            if (apiAddress.UserId < 0)
            {
                throw new Exception("userid cannot be null");
            }

            if (apiAddress.CountryId < 0)
            {
                throw new Exception("country record not found");
            }

            Customer customer = _customerService.GetCustomerById(apiAddress.UserId);
            Address useraddress = new()
            {
                CountryId = apiAddress.CountryId,
                StateProvinceId = apiAddress.StateProviceId,
                County = apiAddress.County,
                Email = apiAddress.Email,
                City = apiAddress.City,
                PhoneNumber = apiAddress.PhoneNumber,
                ZipPostalCode = apiAddress.ZipPostalCode,
                FirstName = apiAddress.FirstName,
                LastName = apiAddress.LastName,
                Address1 = apiAddress.Address1,
                CreatedOnUtc = DateTime.UtcNow
            };
            //add a new address and get the whole new address id
            Address newaddress = _customerService.AddUserAddress(useraddress);

            //update user address mapping with user id and new address id
            _customerService.InsertCutomerAddressMapping(customer, newaddress);


            return Ok();

        }

        //place order.
        /*add all user cart items to order adn deletes from the cart table*/
        [HttpPost]
        [Route("placeorder")]
        public virtual async Task<ActionResult> Placeorder(ApiCheckOutModel apiCheckOut)
        {
            try
            {

                if (apiCheckOut.AddressId < 0 || apiCheckOut.UserId < 0 || string.IsNullOrEmpty(apiCheckOut.PaymentMode))
                {
                    return BadRequest("order request not valid. missing mandatory values");
                };

                int addressid = apiCheckOut.AddressId;
                int userid = apiCheckOut.UserId;
                string paymentmode = apiCheckOut.PaymentMode;

                //shopping cart id
                int carttype = 1;

                Customer customer = await Task.Run(() => _customerService.GetCustomerById(userid));
                List<ApiProduct> product = await Task.Run(() => _productservice.GetMobileCartItem(userid: customer.Id, carttype: carttype));
                // var address = _customerService.GetAddressByUserid(customer.Id);

                decimal ordertotal = await Task.Run(() => _customerService.CalculateOrderTotal(product));

                //prepare order products
                Order order = await Task.Run(() => _customerService.PrepareOrder(customer.Id, addressid, paymentmode, ordertotal));

                //insert order
                Order isordersuccess = await Task.Run(() => _customerService.InsertOrder(order));
                if (isordersuccess is null)
                {
                    throw new Exception("Error posting data");
                };

                //order insert succeeded
                //lets add cartitems to orderitem table
                //var proditems = product.Count;
                //return Ok(proditems);
                foreach (ApiProduct orderedproduct in product)
                {
                    //prepare the item fast
                    OrderItem preparedorderitem = await Task.Run(() => _customerService.PrepareOrderItem(orderedproduct, customer, isordersuccess));

                    //insert the product now
                    await Task.Run(() => _customerService.InsertOrderItem(preparedorderitem));

                };


                //prepare and send email to buyer,shopowner,seller
                GenericAttribute custfname = _apimessageservice.GetCustomerAttributes(customer.Id, "FirstName");
                GenericAttribute custlname = _apimessageservice.GetCustomerAttributes(customer.Id, "LastName");
                Store store = _apimessageservice.GetStore();
                EmailAccount storeemail = _apimessageservice.GetStoreEmail();
                MessageTemplate Notifybuyer = _apimessageservice.GetActiveMessageTemplates("OrderPlaced.CustomerNotification");
                MessageTemplate Notifyseller = _apimessageservice.GetActiveMessageTemplates("OrderPlaced.VendorNotification");
                MessageTemplate Notifystoreowner = _apimessageservice.GetActiveMessageTemplates("OrderPlaced.StoreOwnerNotification");

                //customer email template
                QueuedEmail customernotify = new()
                {
                    From = storeemail.Email,
                    FromName = store.Name,
                    To = customer.Email,
                    ToName = custfname + " " + custlname,
                    ReplyTo = storeemail.Email,
                    ReplyToName = store.CompanyName,
                    Subject = _apimessageservice.ReplaceTemplate(Notifybuyer.Subject, _customerService.GetByEmail(customer.Email), store, storeemail),
                    Body = _apimessageservice.ReplaceTemplate(Notifybuyer.Body, _customerService.GetByEmail(customer.Email), store, storeemail),
                    EmailAccountId = storeemail.Id,
                    PriorityId = 5,
                    CreatedOnUtc = DateTime.UtcNow
                };
                QueuedEmail storenotify = new()
                {
                    From = storeemail.Email,
                    FromName = store.Name,
                    To = storeemail.Email,
                    ToName = storeemail.DisplayName,
                    Subject = _apimessageservice.ReplaceTemplate(Notifyseller.Subject, _customerService.GetByEmail(customer.Email), store, storeemail),
                    Body = _apimessageservice.ReplaceTemplate(Notifyseller.Body, _customerService.GetByEmail(customer.Email), store, storeemail),
                    EmailAccountId = storeemail.Id,
                    PriorityId = 5,
                    CreatedOnUtc = DateTime.UtcNow
                };

                await Task.Run(() => _apimessageservice.AddMsgQueue(storenotify));

                await Task.Run(() => _apimessageservice.AddMsgQueue(customernotify));

                //will use a loop to send mail to different vendors 
                //an order with multiple vendors will require each is sent an email individually
                foreach (ApiProduct productordered in product)
                {
                    int prodid = productordered.ProductId;
                    Vendor vendor = _apimessageservice.GetVendor(prodid);

                    //prepare vendor message
                    QueuedEmail seller = new()
                    {
                        From = storeemail.Email,
                        FromName = store.Name,
                        To = vendor.Email,
                        ToName = vendor.Name,
                        Subject = _apimessageservice.ReplaceTemplate(Notifystoreowner.Subject, _customerService.GetByEmail(customer.Email), store, storeemail),
                        Body = _apimessageservice.ReplaceTemplate(Notifystoreowner.Body, _customerService.GetByEmail(customer.Email), store, storeemail),
                        EmailAccountId = storeemail.Id,
                        PriorityId = 5,
                        CreatedOnUtc = DateTime.UtcNow
                    };
                    await Task.Run(() => _apimessageservice.AddMsgQueue(seller));

                };

                //remove ordered item from the cart table
                await Task.Run(() => _customerService.CleanupCartTable(customer));

                return Ok(new
                {
                    success = true,
                    message = "order placed successfully",

                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "error completing your order\n" + ex,

                }); ;
            }
        }

    }
}
