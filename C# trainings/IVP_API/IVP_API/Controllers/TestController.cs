using Microsoft.AspNetCore.Mvc;

namespace IVP_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("SB")]
        public string SBAccount()
        {
            return "Savings Bank Account Details";
        }

        [HttpGet]
        [Route("CU")]
        public string CUAccount()
        {
            return "Current Bank Account Details";
        }
    }
}
