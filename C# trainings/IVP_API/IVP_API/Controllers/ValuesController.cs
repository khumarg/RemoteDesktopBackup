using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IVP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("GV")]
        public string GetValues()
        {
            return "Returning Customer Values";
        }

        [Route("GI")]
        [HttpGet]
        public string GetInfo()
        {
            return "Returning Basic Information";
        }
    }
}
