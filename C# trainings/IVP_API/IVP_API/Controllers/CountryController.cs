using IVP_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IVP_API.Controllers
{
    //[BindProperties(SupportsGet = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpPost("Get")]
        public IActionResult GetCountry([FromBody] Country country)
        {
            return Ok($"{country.CID} - {country.Name} - {country.Area}");
        }

        [HttpPut("Put/{id}")]
        public IActionResult PutCountry([FromBody] Country country, [FromRoute] int id)
        {
            if (id == 100)
            {
                return Ok($"{country.CID} - {country.Name} - {country.Area}");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("Header")]
        public IActionResult Country([FromHeader] string name, [FromHeader] int id)
        {
            return Ok($"{name} - {id}");
        }

        [HttpPost("HeaderObj")]
        public IActionResult Country([FromHeader] Country country)
        {
            return Ok($"{country.Area} - {country.Name} - {country.CID}");
        }

        //[HttpGet("Get/{CID}/{Name}/{Area}")]
        //public IActionResult GetCountry([FromRoute] Country country)
        //{
        //    return Ok($"{country.CID} - {country.Name} - {country.Area}");
        //}

        //[HttpPost("Add")]
        //public IActionResult AddCountry([FromQuery] Country country)
        //{
        //    return Ok($"{country.CID} - {country.Name} - {country.Area}");
        //}

        //[HttpPut("Edit")]
        //public IActionResult EditCountry([FromForm] Country country)
        //{
        //    return Ok($"{country.CID} - {country.Name} - {country.Area}");
        //}


        //[HttpGet("{id:int}/{name}")]        //Passing parameters using variables / Route
        //public IActionResult GetDetails([FromRoute] int id,[FromRoute] string name)
        //{
        //    return Ok($"{id} - {name}");
        //}

        //[HttpGet("Get")]
        //public IActionResult GetDetails([FromQuery] string name, [FromQuery] int id)
        //{
        //    return Ok($"{id} - {name}");
        //}

        //[HttpPost("Add/{id:int}")]
        //public IActionResult AddDetails([FromQuery] string name, [FromRoute] int id)
        //{
        //    return Ok($"{id} - {name}");
        //}

        //[HttpPut("Edit")]
        //public IActionResult EditDetails([FromForm] string name, [FromForm] int id)
        //{
        //    return Ok($"{id} - {name}");
        //}

        //[HttpPut("Put/{id:int}")]
        //public IActionResult PutDetails([FromForm] string name, [FromRoute] int id, [FromQuery] double area)
        //{
        //    return Ok($"{id} - {name} - {area}");
        //}

        //public string Name { get; set; }
        //public string CID { get; set; }
        //public string area { get; set; }

        ////[BindProperty(SupportsGet = true)]
        //public Country CDetails { get; set; }

        //[HttpPost]
        //[Route("Add")]
        //public IActionResult AddCountry()
        //{
        //    return Ok($"{this.CDetails.CID} - {this.CDetails.Name} - {this.CDetails.Area}");
        //    //return Ok($"{this.Name} - {this.CID} - {this.area}");
        //}

        //[HttpGet]
        //[Route("Get")]
        //public IActionResult GetCountry()
        //{
        //    return Ok($"{this.CDetails.CID} - {this.CDetails.Name} - {this.CDetails.Area}");
        //    //return Ok($"{this.Name} - {this.CID} - {this.area}");
        //}
    }
    }
