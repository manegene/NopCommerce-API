using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.ApiUser;

namespace Nop.RestApi.Service.Services.Core
{
    public interface IApiMessageService
    {
        //get the active message template to use in the email
        MessageTemplate GetActiveMessageTemplates(string messageTemplateName);

        Store GetStore();
        EmailAccount GetStoreEmail();

        string ReplaceTemplate(string template, ApiCustomer customer, Store store, EmailAccount emailAccount);
        Setting ReadSettings(int storeid, string settingname);
        void AddMsgQueue(QueuedEmail queuedEmail);
        Vendor GetVendor(int productid);
        GenericAttribute GetCustomerAttributes(int userid, string keyvalue);
    }
}
