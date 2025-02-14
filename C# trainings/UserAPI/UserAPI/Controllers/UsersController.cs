using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Models;
using UserAPI.Models.UserRepo;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUser _user;

        public UsersController(IUser user)
        {
            _user = user;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _user.GetAllUsersAsync();

            return Ok(users);
        }

        [HttpGet("Get/{id:int}")]
        public async Task<IActionResult> GetUserByID(int id)
        {
            var user = await _user.GetUserByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(user);
            }
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            if(user == null)
            {
                return BadRequest();
            } else
            {
                await _user.AddUserAsync(user);

                return CreatedAtAction(nameof(GetUserByID), new { id = user.Id, Controller = "users" }, user);
            }
        }

        [HttpPut("Update/{id:int}")]
        public async Task<IActionResult> UpdateUser([FromBody] User user, [FromRoute] int id)
        {
            if(id != user.Id)
            {
                return BadRequest();
            } else
            {
                await _user.UpdateUserAsync(user);

                return NoContent();
            }
        }

        [HttpDelete("Delete/{id:int}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var data = await _user.DeleteUserAsync(id);

            return Ok(data);
        }
    }
}
