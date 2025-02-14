using Microsoft.AspNetCore.Mvc;
using Moq;
using UserAPI.Controllers;
using UserAPI.Models;
using UserAPI.Models.UserRepo;

namespace UserAPI_Test
{
    public class UserController_Tests
    {
        private readonly UsersController _uc;

        private readonly Mock<IUser> _mockIUser;

        public UserController_Tests()
        {
            _mockIUser = new Mock<IUser>();

            _uc = new UsersController(_mockIUser.Object);
        }

        [Fact]
        public async Task GetAllUsers_ReturnsOkResultWithListOfUsers()
        {
            var users = new List<User>()
            {
                new User() { Id = 10, Name = "Nikhil", Email = "nikhil@ivp.in" },
                new User() { Id = 20, Name = "Richa", Email = "richa@ivp.in" },
                new User() { Id = 30, Name = "Jack", Email = "jack@ivp.in" }
            };

            _mockIUser.Setup(service => service.GetAllUsersAsync()).ReturnsAsync(users);

            var data = await _uc.GetAllUsers() as OkObjectResult;

            Assert.NotNull(data);
            Assert.Equal(200, data.StatusCode);
            Assert.Equal(users, data.Value);
        }

        [Theory]
        [InlineData(10, true)]
        [InlineData(100, false)]
        public async Task GetUserById_ReturnsExpectedResult(int userId, bool userExists)
        {
            var expectedUser = userExists ? new User() { Id = 10, Name = "Nikhil", Email = "nikhil@ivp.in" } : null;

            _mockIUser.Setup(service => service.GetUserByIdAsync(userId)).ReturnsAsync(expectedUser);

            var data = await _uc.GetUserByID(userId);

            if(userExists)
            {
                var info = Assert.IsType<OkObjectResult>(data);
                Assert.NotNull(info.Value);
                Assert.Equal(expectedUser.Id, ((User)info.Value).Id);
                Assert.Equal(expectedUser.Name, ((User)info.Value).Name);
                Assert.Equal(expectedUser.Email, ((User)info.Value).Email);
            } else
            {
                Assert.IsType<NotFoundResult>(data);
            }
        }

        [Fact]
        public async Task AddUser_ReturnsCreatedAtActionResult()
        {
            var newUser = new User() { Id = 40, Name = "Prachi", Email = "prachi@ivp.in"};

            var data = await _uc.AddUser(newUser) as CreatedAtActionResult;

            Assert.NotNull(data);
            Assert.Equal(201, data.StatusCode);
            Assert.Equal("GetUserByID", data.ActionName);
            Assert.Equal(newUser.Id, ((User)data.Value).Id);
        }

        [Fact]
        public async Task UpdateUser_ReturnsNoContent()
        {
            var updatedData = new User() { Id = 10, Name = "Nikhil", Email = "nikhil2@ivp.in" };

            var data = await _uc.UpdateUser(updatedData, 10) as NoContentResult;

            Assert.NotNull(data);
            Assert.Equal(204, data.StatusCode);
        }

        [Fact]
        public async Task UpdateUserAsync_ReturnsBadRequest_WhenIdMismatch()
        {
            var updatedData = new User() { Id = 10, Name = "Nikhil", Email = "nikhil2@ivp.in" };

            var data = await _uc.UpdateUser(updatedData, 100) as BadRequestResult;

            Assert.NotNull(data);
            Assert.Equal(400, data.StatusCode);
        }

        [Fact]
        public async Task DeleteUser_ReturnsNoContent()
        {
            var data = await _uc.DeleteUser(10) as OkObjectResult;

            Assert.NotNull(data);
            Assert.Equal(200, data.StatusCode);
        }
    }
}
