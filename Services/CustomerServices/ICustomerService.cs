using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.ApiUser;
using Nop.RestApi.Service.Models.Catalogue;
using Nop.RestApi.Service.Models.CheckOut;
using System.Collections.Generic;

namespace Nop.RestApi.Service.Services.CustomerServices
{
    public interface ICustomerService
    {
        string EncryptText(string plainText, string encryptionPrivateKey = "");
        byte[] EncryptTextToMemory(string data, byte[] key, byte[] iv);
        string CreatePasswordHash(string password, string saltkey, string passwordFormat);
        string CreateHash(byte[] data, string hashAlgorithm, int trimByteCount = 0);
        bool PasswordsMatch(CustomerPassword customerPassword, string enteredPassword);
        string GenerateSalt();
        decimal CalculateOrderTotal(IList<ApiProduct> apiProducts);
        Customer GetCustomerById(int userid);

        ApiCustomer GetByEmail(string email);
        CustomerPassword GetCustomerSavedPass(int userid);
        bool InsertCustomer(Customer customer);

        void UpdateCustomerRole(CustomerCustomerRoleMapping customerCustomerRoleMapping);

        void InsertPassword(CustomerPassword customerpassword);

        void InsertAtts(GenericAttribute genericAttribute);

        #region orders

        IList<ApiAddress> GetAddressByUserid(int Userid);

        IList<ApiAddress> GetCountries();

        IList<ApiAddress> GetStateProvinces();

        IList<ApiProduct> GetOrderedItems(int userid);

        Address AddUserAddress(Address address);

        void InsertCutomerAddressMapping(Customer customer, Address address);

        Order PrepareOrder(int userid, int addressid, string paymentmode, decimal ordertotal);
        Order InsertOrder(Order order);
        OrderItem PrepareOrderItem(ApiProduct apiProduct, Customer customer, Order order);

        void InsertOrderItem(OrderItem orderItem);

        void CleanupCartTable(Customer customer);
        #endregion orders
    }
}
