using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IVPLoggingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;

            _logger.LogInformation("Logging started for Test Controller");
        }

        [HttpGet]
        public IActionResult GetInformation()
        {
            _logger.LogInformation("Get Method Called");
            return Ok("Data sent successfully");
        }

        [HttpGet("Divide")]
        public IActionResult Divide()
        {
            _logger.LogInformation("Divide Method Called" + DateTime.Now.ToString());

            int x = 10;
            int y = 0;

            _logger.LogInformation($"Value of x = {x} and y = {y}");

            try
            {
                return Ok(x / y);
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occurred");
                _logger.LogCritical(ex.Message);
            }
            finally
            {
                _logger.LogInformation("Method execution over" + DateTime.Now.ToString());
            }

            return BadRequest();
        }
    }
}
