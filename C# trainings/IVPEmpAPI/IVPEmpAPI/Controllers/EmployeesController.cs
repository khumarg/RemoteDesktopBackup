using EmpModels.Models;
using IVPEmpAPI.EmployeeRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace IVPEmpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployee _emp;

        public EmployeesController(IEmployee emp)
        {
            _emp = emp;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var info = await _emp.GetAllEmployees();

            if (info == null)
            {
                return NotFound();
            } else
            {
                return Ok(info);
            }
        }

        [HttpGet]
        [Route("Fetch/{id:int:range(10, 1000)}")]
        public async Task<IActionResult> GetEmpByID([FromRoute] int id)
        {
            var emp = await _emp.GetEmployeeByID(id);

            if (emp == null)
            {
                return BadRequest();
            } else
            {
                return Ok(emp);
            }
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddEmp([FromBody] Employee employee)
        {
            int id = await _emp.AddEmployee(employee);

            //return Ok(str);
            return CreatedAtAction(nameof(GetEmpByID), new { id = id, Controller = "Employees" }, id);
        }

        [HttpDelete("Delete/{id:int:max(1000):min(10)}")]
        public async Task<IActionResult> DeleteEmp([FromRoute] int id)
        {
            string str = await _emp.DeleteEmployee(id);
            return Ok(str);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> EditEmp([FromBody] Employee emp, [FromQuery] int id)
        {
            string str = await _emp.UpdateEmployee(emp, id);

            return Ok(str);
        }

        [HttpPatch("EditSalary/{id:int}")]
        public async Task<IActionResult> EditSalary([FromRoute] int id, [FromBody] JsonPatchDocument patch)
        {
            string str = await _emp.UpdateEmployeeSalary(id, patch);

            return Ok(str);
        }
    }
}
