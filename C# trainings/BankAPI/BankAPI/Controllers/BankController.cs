using BankAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        SecurityDb3685Context _context;

        public BankController(SecurityDb3685Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult GetAllDetails()
        {
            var data = _context.Banks.ToList();
            return Ok(data);
        }

        [HttpGet]
        [Route("Get/{id:int}")]
        public IActionResult GetAllDetails(int id)
        {
            var data = _context.Banks.Find(id);
            return Ok(data);
        }

        [HttpPost("Add")]
        public IActionResult AddDetails(Bank bank)
        {
            _context.Banks.Add(bank);
            _context.SaveChanges();

            return Ok("Data Added Successfully");
        }

        [HttpDelete("Delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var data = _context.Banks.Find(id);
            _context.Remove(data);
            _context.SaveChanges();

            return Ok("Successfully Deleted");
        }

        [HttpPut("Update/{id:int}")]
        public IActionResult Update(int id, Bank bank)
        {
            _context.Banks.Update(bank);
            _context.SaveChanges();

            return Ok("Updated Successfully");
        }
    }
}
