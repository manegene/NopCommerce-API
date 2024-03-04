using Nop.RestApi.Service.Models.core;
using System;
using System.Linq;

namespace Nop.RestApi.Service.Services.Core
{
    public class ApiAboutService : IApiAboutService
    {
        #region fields
        private readonly ApiContext _apiContext;
        #endregion fields
        #region ctor
        public ApiAboutService(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }
        #endregion ctor
        public APiStoreAbout getStoreDetails()
        {
            var about = _apiContext.Stores.
                Select(newstore => new APiStoreAbout
                {
                    StoreName = newstore.Name,
                    StoreMobile = newstore.CompanyPhoneNumber,
                    StoreLocation=newstore.CompanyAddress,

                    About = _apiContext.Topics.Where(topic=>topic.SystemName == "AboutUs")
                    .Select(body=>body.Body).FirstOrDefault(),

                    StoreEmail = _apiContext.EmailAccounts
                    .Where(eml => eml.DisplayName.Contains("contact"))
                    .Select(emailname => emailname.Email).FirstOrDefault()
                });

            return about.FirstOrDefault();
        }
    }
}
