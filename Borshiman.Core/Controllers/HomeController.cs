using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Borshiman.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get() =>
                    Ok("Yup its working !!!");
    }
}
