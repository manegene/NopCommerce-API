using Microsoft.AspNetCore.Mvc;
using Nop.RestApi.Service.Models.core;
using Nop.RestApi.Service.Services.Core;

namespace Nop.RestApi.Service.Controllers.Core
{
    public class StoreAboutController : BaseAuthController
    {
        #region fields
        private IApiAboutService _apiAboutService;
        #endregion fields
        #region ctor
        public StoreAboutController(IApiAboutService apiAboutService)
        {
            _apiAboutService = apiAboutService;
        }
        #endregion ctor

        #region methods
        [HttpGet]
        public ActionResult<APiStoreAbout> GetStoreAbout()
        {
            var store= _apiAboutService.getStoreDetails();
            if(store!= null)
            {
                return Ok(store);
            }
            else
            {
                return BadRequest("store not found");
            }

        }
        #endregion methods

    }
}
