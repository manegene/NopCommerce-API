using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Nop.RestApi.Service.Controllers.Core
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class BaseAuthController : ControllerBase
    {

    }
}
