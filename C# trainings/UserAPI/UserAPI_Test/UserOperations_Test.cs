using UserAPI.Models;
using UserAPI.Models.UserRepo;

namespace UserAPI_Test
{
    public class UserOperations_Test
    {
        private readonly UserOperations _userops;

        public UserOperations_Test()
        {
            _userops = new UserOperations();
        }

        [Theory]
        [InlineData(10, true)]
        [InlineData(100, false)]
        public async Task GetUserByID_ExpectedResult(int id, bool userExists)
        {
            var data = await _userops.GetUserByIdAsync(id);

            if (userExists)
            {
                Assert.NotNull(data);
                Assert.Equal(id, data.Id);
            }
            else
            {
                Assert.Null(data);
            }
        }

        [Fact]
        public async Task GetAllUsersAsync_ReturnsAllUsers()
        {
            var data = await _userops.GetAllUsersAsync();

            Assert.NotNull(data);
            Assert.Equal(3, data.Count());
        }

        [Fact]
        public async Task AddUserAsync_AddsUserCorrectly()
        {
            User newUser = new User() { Id = 40, Name = "Jill", Email = "Jill@ivp.in" };

            await _userops.AddUserAsync(newUser);
            var data = await _userops.GetUserByIdAsync(newUser.Id);

            Assert.NotNull(data);
            Assert.Equal(data.Id, newUser.Id);
            Assert.Equal(data.Name, newUser.Name);
            Assert.Equal(data.Email, newUser.Email);
        }

        [Fact]
        public async Task UpdateUserAsync_UpdatesUserCorrectly()
        {
            var user = new User { Id = 30, Name = "Jack updated", Email = "jack.updated@example.com" };

            // Act
            await _userops.UpdateUserAsync(user);
            var data = await _userops.GetUserByIdAsync(user.Id);

            // Assert
            Assert.NotNull(data);
            Assert.Equal(user.Name, data.Name);
            Assert.Equal(user.Email, data.Email);
            Assert.NotEqual("Jack", data.Name);
            Assert.NotEqual("jack@ivp.in", data.Email);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        public async Task DeleteUserAsync_DeletesUserCorrectly(int id)
        {
            var userID = id;

            var user = await _userops.DeleteUserAsync(userID);

            var data = await _userops.GetUserByIdAsync(userID);

            Assert.Null(data);
        }
    }
}