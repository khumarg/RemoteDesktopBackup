using Microsoft.AspNetCore.Http.HttpResults;

namespace UserAPI.Models.UserRepo
{
    public class UserOperations : IUser
    {
        private List<User> _user;

        public UserOperations()
        {
            _user = new List<User>
            {
                new User() { Id = 10, Name = "Nikhil", Email = "nikhil@ivp.in" },
                new User() { Id = 20, Name = "Richa", Email = "richa@ivp.in" },
                new User() { Id = 30, Name = "Jack", Email = "jack@ivp.in" }
            };
        }
        public async Task AddUserAsync(User user)
        {
            await Task.Delay(1000);

            _user.Add(user);
        }

        public async Task<IEnumerable<User>> DeleteUserAsync(int userId)
        {
            await Task.Delay(1000);

            var data = _user.Find(x => x.Id == userId);

            if (data != null)
            {
                _user.Remove(data);
            }

            return _user;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            await Task.Delay(1000);
            return _user;
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            await Task.Delay(1000);
            return _user.FirstOrDefault(x => x.Id == userId);
        }

        public async Task UpdateUserAsync(User user)
        {
            await Task.Delay(1000);

            var data = _user.Find(x => x.Id == user.Id);

            if(data != null)
            {
                data.Name = user.Name;
                data.Email = user.Email;
            }
        }
    }
}
