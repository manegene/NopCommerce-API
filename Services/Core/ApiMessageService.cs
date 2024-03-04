using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.ApiUser;
using Nop.RestApi.Service.Models.core;
using System.Linq;
using System.Text;

namespace Nop.RestApi.Service.Services.Core
{
    public class ApiMessageService : IApiMessageService
    {
        #region fields
        private readonly ApiContext _apiContext;
        #endregion fields
        #region ctor
        public ApiMessageService(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }
        #endregion ctor
        #region methods
        public virtual MessageTemplate GetActiveMessageTemplates(string messageTemplateName)
        {
            IQueryable<MessageTemplate> temp = _apiContext.MessageTemplates.Where(m => m.Name == messageTemplateName && m.IsActive == true);
            return temp.FirstOrDefault();
        }

        //you get the store values
        public Store GetStore()
        {
            return _apiContext.Stores.OrderBy(id => id.DefaultLanguageId).FirstOrDefault();
        }

        public virtual GenericAttribute GetCustomerAttributes(int userid, string keyvalue)
        {
            return _apiContext.GenericAttributes
                .Where(att => att.EntityId == userid && att.KeyGroup == "Customer" && att.Key == keyvalue)
                .FirstOrDefault();
        }

        //read store settings
        public virtual Setting ReadSettings(int storeid, string settingname)
        {
            IQueryable<Setting> store = from settings in _apiContext.Settings.Where(str => str.StoreId == storeid && str.Name == settingname)
                                        select settings;

            return store.FirstOrDefault();

        }

        //get vendor of a product
        public virtual Vendor GetVendor(int productid)
        {
            int prod = _apiContext.Products.Where(prd => prd.Id == productid).FirstOrDefault().VendorId;
            return _apiContext.Vendors.Where(vid => vid.Active == true && vid.Deleted == false && vid.Id == prod).FirstOrDefault();
        }
        //get email
        public EmailAccount GetStoreEmail()
        {
            return _apiContext.EmailAccounts.OrderBy(id => id.Id).FirstOrDefault();
        }
        //update subject and message body tokens
        public string ReplaceTemplate(string template, ApiCustomer customer, Store stor, EmailAccount storeemail)
        {

            StringBuilder newtemplate = new(template);


            //get last ordered item
            Order customerorderdetails = _apiContext.Orders.Where(us => us.CustomerId == customer.Userid).OrderBy(ord => ord.Id).LastOrDefault();

            //if (customerorderdetails != null)
            //{
            Address ShipandBilling = _apiContext.Addresses.Where(addr => addr.Id == customerorderdetails.BillingAddressId).FirstOrDefault();
            //}

            //optinally suppy avendor product name
            Product prods = _apiContext.Products.Where(prd =>
            prd.Id == _apiContext.OrderItems.Where(prdid => prdid.
            OrderId == customerorderdetails.Id)
            .FirstOrDefault().ProductId && prd.VendorId == _apiContext.Vendors
            .Where(vid => vid.Id == prd.VendorId)
            .FirstOrDefault().Id)
                .FirstOrDefault();


            //check store token and replace them
            foreach (string tok in ApiTokens.StoreTokens)
            {
                if (template.Contains(tok))
                {
                    switch (tok)
                    {
                        case "%Store.URL%":
                            _ = newtemplate.Replace(tok, stor.Url);
                            break;
                        case "%Store.Name%":
                            _ = newtemplate.Replace(tok, stor.Name);
                            break;
                        case "%Store.CompanyName%":
                            _ = newtemplate.Replace(tok, stor.CompanyName);
                            break;
                        case "%Store.CompanyPhoneNumber%":
                            _ = newtemplate.Replace(tok, stor.CompanyPhoneNumber);
                            break;
                        case "%Store.Email%":
                            _ = newtemplate.Replace(tok, storeemail.Email);
                            break;
                    }
                }
            }
            //also check and replace customer tokens
            foreach (string tok in ApiTokens.CustTokens)
            {
                if (template.Contains(tok))
                {
                    switch (tok)
                    {
                        case "%Customer.Email%":
                            _ = newtemplate.Replace(tok, customer.Email);
                            break;
                        case "%Customer.Username% ":
                            _ = newtemplate.Replace(tok, customer.Username);
                            break;
                        case "%Customer.FullName%":
                            _ = newtemplate.Replace(tok, customer.Firstname + customer.LastName);
                            break;
                        case "%Customer.FirstName%":
                            _ = newtemplate.Replace(tok, customer.Firstname);
                            break;
                        case "%Customer.LastName%":
                            _ = newtemplate.Replace(tok, customer.LastName);
                            break;

                    }
                }
            }

            //update order order token
            foreach (string tok in ApiTokens.OrderTokens)
            {
                if (template.Contains(tok))
                {
                    switch (tok)
                    {
                        case "%Order.CustomerEmail%":
                            _ = newtemplate.Replace(tok, customer.Email);
                            break;
                        case "%Order.OrderNumber%":
                            _ = newtemplate.Replace(tok, customerorderdetails.CustomOrderNumber);
                            break;
                        case "%Order.CustomerFullName%":
                            _ = newtemplate.Replace(tok, customer.Firstname + customer.LastName);
                            break;
                        case "%Order.BillingFirstName%" or "%Order.ShippingFirstName%":
                            _ = newtemplate.Replace(tok, customer.Firstname);
                            break;
                        case "%Order.BillingLastName%" or "%Order.ShippingLastName%":
                            _ = newtemplate.Replace(tok, customer.LastName);
                            break;
                        case "%Order.BillingPhoneNumber%":
                            _ = newtemplate.Replace(tok, customer.Phone);
                            break;
                        case "%Order.BillingEmail%" or "%Order.ShippingEmail%":
                            _ = newtemplate.Replace(tok, customer.Email);
                            break;
                        case "%Order.OrderId%":
                            _ = newtemplate.Replace(tok, customerorderdetails.CustomOrderNumber);
                            break;
                        case "%Order.CreatedOn%":
                            _ = newtemplate.Replace(tok, customerorderdetails.CreatedOnUtc.ToString());
                            break;
                        case "%Order.PaymentMethod%":
                            _ = newtemplate.Replace(tok, customerorderdetails.PaymentMethodSystemName);
                            break;
                        case "%Order.ShippingCountry%" or "%Order.BillingCountry%":
                            _ = newtemplate.Replace(tok, _apiContext.Countries.Where(sid => sid.Id == ShipandBilling.CountryId).FirstOrDefault().Name);
                            break;
                        case "%Order.ShippingZipPostalCode%" or "%Order.BillingZipPostalCode%":
                            _ = newtemplate.Replace(tok, ShipandBilling.ZipPostalCode);
                            break;
                        case "%Order.ShippingStateProvince%" or "%Order.BillingStateProvince%":
                            _ = newtemplate.Replace(tok, _apiContext.StateProvinces.Where(sid => sid.Id == ShipandBilling.StateProvinceId).FirstOrDefault().Name);
                            break;
                        case "%Order.ShippingCounty%" or "%Order.BillingCounty%":
                            _ = newtemplate.Replace(tok, ShipandBilling.County);
                            break;
                        case "%Order.ShippingCity%" or "%Order.BillingCity%":
                            _ = newtemplate.Replace(tok, ShipandBilling.City);
                            break;
                        case "%Order.ShippingAddress1%" or "%Order.BillingAddress1%":
                            _ = newtemplate.Replace(tok, ShipandBilling.Address1);
                            break;
                        case "%Order.Product(s)%":
                            _ = newtemplate.Replace(tok, prods.Name);
                            break;



                    }
                }
            }

            return newtemplate.ToString();
        }


        //insert new message queue
        public void AddMsgQueue(QueuedEmail queuedEmail)
        {
            _ = _apiContext.Add(queuedEmail);
            _ = _apiContext.SaveChanges();
        }
        #endregion methods
    }
}
