using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.ApiUser;
using Nop.RestApi.Service.Models.Catalogue;
using Nop.RestApi.Service.Models.CheckOut;
using Nop.RestApi.Service.Models.core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Nop.RestApi.Service.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        #region fields
        private readonly Random _random;

        private readonly ApiContext _context;
        #endregion fields
        #region ctor
        public CustomerService(ApiContext apiContext, Random random)
        {
            _context = apiContext;
            _random = random;
        }
        #endregion ctor
        #region complimentary service
        public virtual byte[] EncryptTextToMemory(string data, byte[] key, byte[] iv)
        {
            using MemoryStream ms = new();
            using (TripleDES tripleDESalg = TripleDES.Create())

            using (CryptoStream cs = new(ms, tripleDESalg.CreateEncryptor(key, iv), CryptoStreamMode.Write))
            {
                byte[] toEncrypt = Encoding.Unicode.GetBytes(data);
                cs.Write(toEncrypt, 0, toEncrypt.Length);
                cs.FlushFinalBlock();
            }

            return ms.ToArray();
        }
        public virtual string EncryptText(string plainText, string encryptionPrivateKey = "")
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return plainText;
            }

            if (string.IsNullOrEmpty(encryptionPrivateKey))
            {
                encryptionPrivateKey = _context.Settings.Where(name => name.Name == "securitysettings.encryptionkey").FirstOrDefault().Value;
            }

            using TripleDES provider = TripleDES.Create();
            {
                provider.Key = Encoding.ASCII.GetBytes(encryptionPrivateKey.Substring(0, 16));
                provider.IV = Encoding.ASCII.GetBytes(encryptionPrivateKey.Substring(8, 8));
            };

            byte[] encryptedBinary = EncryptTextToMemory(plainText, provider.Key, provider.IV);
            return Convert.ToBase64String(encryptedBinary);
        }

        public virtual string CreateHash(byte[] data, string hashAlgorithm, int trimByteCount = 0)
        {
            if (string.IsNullOrEmpty(hashAlgorithm))
            {
                throw new ArgumentNullException(nameof(hashAlgorithm));
            }

            HashAlgorithm algorithm = (HashAlgorithm)CryptoConfig.CreateFromName(hashAlgorithm);
            if (algorithm == null)
            {
                throw new ArgumentException("Unrecognized hash name");
            }

            if (trimByteCount > 0 && data.Length > trimByteCount)
            {
                byte[] newData = new byte[trimByteCount];
                Array.Copy(data, newData, trimByteCount);

                return BitConverter.ToString(algorithm.ComputeHash(newData)).Replace("-", string.Empty);
            }

            return BitConverter.ToString(algorithm.ComputeHash(data)).Replace("-", string.Empty);
        }

        public virtual string CreatePasswordHash(string password, string saltkey, string passwordFormat)
        {
            return CreateHash(Encoding.UTF8.GetBytes(string.Concat(password, saltkey)), passwordFormat);
        }
        public virtual string GenerateSalt()
        {
            int length = 12;
            byte[] values = new byte[length];
            _random.NextBytes(values);
            string sring = Convert.ToBase64String(values);
            return sring;
        }
        public bool PasswordsMatch(CustomerPassword customerPassword, string enteredPassword)
        {
            if (customerPassword == null || string.IsNullOrEmpty(enteredPassword))
            {
                return false;
            }

            string savedPassword = string.Empty;
            switch (customerPassword.PasswordFormatId)
            {
                case 0:
                    savedPassword = enteredPassword;
                    break;
                case 2:
                    savedPassword = EncryptText(enteredPassword);
                    break;
                case 1:
                    savedPassword = CreatePasswordHash(enteredPassword, customerPassword.PasswordSalt, "SHA512");
                    break;
            }

            return customerPassword.Password != null && customerPassword.Password.Equals(savedPassword);
        }

        //calculate order total price
        public virtual decimal CalculateOrderTotal(IList<ApiProduct> apiProducts)
        {
            decimal ordertotal = 0;
            foreach (ApiProduct produc in apiProducts)
            {
                int noofprod = _context.ShoppingCartItems.Where(prodid => prodid.ProductId == produc.ProductId && prodid.ShoppingCartTypeId == 1).FirstOrDefault().Quantity;
                decimal singleprodtotal = produc.Price * noofprod;
                ordertotal += singleprodtotal;
            }
            return ordertotal;
        }
        #endregion complimentray service
        #region main methods
        //return customer by userid
        public Customer GetCustomerById(int userid)
        {
            Customer getcustomer = (from cust in _context.Customers
                                    where cust.Id == userid && cust.Active == true
                                    select cust).FirstOrDefault();
            return getcustomer;
        }

        //retun user with the email
        //return all necesary api user details
        public ApiCustomer GetByEmail(string email)
        {
            if (email == null)
            {
                return null;
            }

            ApiCustomer User = (from cu in _context.Customers
                .Where(useremail => useremail.Username == email || useremail.Email == email)
                .Where(cust => cust.Active == true && cust.Deleted == false && cust.Active == true)
                                select new ApiCustomer
                                {
                                    Message = cu.Id.ToString(),
                                    Userid = cu.Id,
                                    Username = cu.Username,
                                    Email = cu.Email,
                                    CustomerGuid = cu.CustomerGuid,
                                    Statuscode = true,
                                    AddressId = cu.BillingAddressId,
                                    Firstname = _context.GenericAttributes.Where(gen => gen.EntityId == cu.Id && gen.Key == "FirstName").Select(val => val.Value).FirstOrDefault(),
                                    LastName = _context.GenericAttributes.Where(gen => gen.EntityId == cu.Id && gen.Key == "LasttName").Select(val => val.Value).FirstOrDefault(),
                                    Phone = _context.GenericAttributes.Where(gen => gen.EntityId == cu.Id && gen.Key == "Phone").Select(val => val.Value).FirstOrDefault(),
                                    Active = cu.Active
                                }).FirstOrDefault();
            return User;
        }
        //return saved userpassword string
        public virtual CustomerPassword GetCustomerSavedPass(int userid)
        {
            if (userid <= 0)
            {
                return null;
            }

            CustomerPassword userpass = _context.CustomerPasswords
                .Where(upas => upas.CustomerId == userid)
                .OrderBy(passid => passid.Id).LastOrDefault();
            return userpass;
        }

        //first insert customer details successfully
        public virtual bool InsertCustomer(Customer customer)
        {
            if (customer == null)
            {
                return false;
            }

            _ = _context.Add(customer);
            _ = _context.SaveChanges();

            return true;
        }
        public virtual void UpdateCustomerRole(CustomerCustomerRoleMapping customerCustomerRoleMapping)
        {
            CustomerCustomerRoleMapping checkexixts = _context.CustomerCustomerRoleMappings.
                              Where(uid => uid.CustomerId == customerCustomerRoleMapping.CustomerId).FirstOrDefault();

            //update user role if already exixting in store role mapping
            if (checkexixts != null)
            {
                checkexixts.CustomerRoleId = 3;
                _ = _context.SaveChanges();
            }
            //otherwise insert a new user role record mapping

            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<CustomerCustomerRoleMapping> updaterole = _context.CustomerCustomerRoleMappings.Add(customerCustomerRoleMapping);
            _ = _context.SaveChanges();
        }

        public virtual void InsertPassword(CustomerPassword customerpassword)
        {
            _ = _context.Add(customerpassword);
            _ = _context.SaveChanges();
        }
        public virtual void InsertAtts(GenericAttribute genericAttribute)
        {
            _ = _context.Add(genericAttribute);
            _ = _context.SaveChanges();

        }

        #region orders

        public virtual IList<ApiAddress> GetAddressByUserid(int Userid)
        {
            if (Userid <= 0)
            {
                return null;
            }

            IQueryable<ApiAddress> address = from ad in _context.Addresses
                                             join cuadd in _context.CustomerAddresses on ad.Id equals cuadd.AddressId
                                             where cuadd.CustomerId == Userid
                                             select new ApiAddress
                                             {
                                                 Id = ad.Id,
                                                 UserId = cuadd.CustomerId,
                                                 FirstName = ad.FirstName,
                                                 LastName = ad.LastName,
                                                 Email = ad.Email,
                                                 Country = _context.Countries.Where(cuid => cuid.Id == ad.CountryId).FirstOrDefault().Name,
                                                 County = ad.County,
                                                 ZipPostalCode = ad.ZipPostalCode,
                                                 City = ad.City,
                                                 PhoneNumber = ad.PhoneNumber
                                             };
            return address.ToList();

        }

        public virtual IList<ApiAddress> GetCountries()
        {
            return _context.Countries.Where(isactive => isactive.Published == true).Select(countl => new ApiAddress
            {
                Id = countl.Id,
                Country = countl.Name
            }).ToList();
        }

        public virtual IList<ApiProduct> GetOrderedItems(int userid)
        {
            IQueryable<ApiProduct> orderitems = from orderedprod in _context.OrderItems
                                                join ordered in _context.Orders on orderedprod.OrderId equals ordered.Id
                                                join prod in _context.Products on orderedprod.ProductId equals prod.Id
                                                where ordered.CustomerId == userid
                                                select new ApiProduct
                                                {
                                                    Id = prod.Id,
                                                    ProductId = prod.Id,
                                                    Pname = prod.Name,
                                                    ShortDescription = prod.ShortDescription,
                                                    Price = orderedprod.UnitPriceInclTax,
                                                    Currency = _context.Currencies.Where(pub => pub.Published == true).Select(cucode => cucode.CurrencyCode).FirstOrDefault(),
                                                    Imagename = prod.ProductPictureMappings.Select(x => x.Picture.SeoFilename).FirstOrDefault(),
                                                    Prodpicid = prod.ProductPictureMappings.Select(x => x.Picture.Id).FirstOrDefault(),
                                                    Imagetype = prod.ProductPictureMappings.Select(x => x.Picture.MimeType).FirstOrDefault(),
                                                    Oldprice = prod.OldPrice

                                                };
            return orderitems.ToList();
        }

        //add user address
        public virtual Address AddUserAddress(Address address)
        {
            _ = _context.Add(address);
            _ = _context.SaveChanges();

            //we retunr the whole address object. will need the address id to map it to the user-address mpping table
            return address;
        }

        public virtual void InsertCutomerAddressMapping(Customer customer, Address address)
        {
            CustomerAddress newmapping = new()
            {
                CustomerId = customer.Id,
                AddressId = address.Id
            };
            _ = _context.Add(newmapping);
            _ = _context.SaveChanges();
        }

        //prepare order
        public virtual Order PrepareOrder(int userid, int addressid, string paymentmode, decimal ordertotal)
        {
            decimal shipingfee = Convert.ToDecimal(_context.Settings.Where(sp => sp.Name.Contains("shippingratecomputationmethod.fixedbyweightbytotal.rate")).FirstOrDefault().Value);
            Order ordered = new()
            {
                CustomerId = userid,
                BillingAddressId = addressid,
                ShippingAddressId = addressid,
                OrderGuid = Guid.NewGuid(),
                StoreId = _context.Stores.FirstOrDefault().Id,
                PickupInStore = false,
                OrderStatusId = 10,
                ShippingStatusId = 0,
                PaymentStatusId = 10,
                PaymentMethodSystemName = paymentmode,
                CustomerCurrencyCode = _context.Currencies.Where(cu => cu.Published == true).FirstOrDefault().CurrencyCode,
                CurrencyRate = 1,
                OrderShippingInclTax = shipingfee,
                OrderTotal = ordertotal + shipingfee,
                OrderTax = 0,
                ShippingRateComputationMethodSystemName = "Shipping.FixedByWeightByTotal",
                CreatedOnUtc = DateTime.UtcNow,
                CustomOrderNumber = string.Empty

            };
            return ordered;
        }

        //insert order and return oder to get orderid
        public virtual Order InsertOrder(Order order)
        {
            _ = _context.Add(order);
            _ = _context.SaveChanges();

            //get order id and update the order item to same value
            order.CustomOrderNumber = order.Id.ToString();
            _ = _context.SaveChanges();

            return order;

        }

        //insert orderitem
        public virtual OrderItem PrepareOrderItem(ApiProduct apiProduct, Customer customer, Order order)
        {
            OrderItem orderItem = new()
            {
                OrderId = order.Id,
                ProductId = apiProduct.ProductId,
                OrderItemGuid = Guid.NewGuid(),
                Quantity = apiProduct.Quantity,
                UnitPriceInclTax = apiProduct.Price,
                UnitPriceExclTax = apiProduct.Price,
                PriceExclTax = 0,
                OriginalProductCost = apiProduct.Oldprice,
                AttributesXml = apiProduct.OrderProdAttributeXML
            };
            return orderItem;
        }

        public virtual void InsertOrderItem(OrderItem orderItem)
        {
            _ = _context.Add(orderItem);
            _ = _context.SaveChanges();
        }

        public virtual void CleanupCartTable(Customer customer)
        {
            IQueryable<ShoppingCartItem> deletemenow = _context.ShoppingCartItems.Where(me => me.CustomerId == customer.Id && me.ShoppingCartTypeId == 1);
            _context.RemoveRange(deletemenow);
            _ = _context.SaveChanges();
        }

        public IList<ApiAddress> GetStateProvinces()
        {
            List<ApiAddress> states = _context.StateProvinces.
                Where(cid => cid.Published == true
                && cid.Country.Published == true
                && cid.CountryId == cid.Country.Id)
                .Select(apiadd => new ApiAddress
                {
                    Id = apiadd.Id,
                    Province = apiadd.Name
                }).ToList();

            return states;
        }


        #endregion orders


        #endregion main methods
    }
}
