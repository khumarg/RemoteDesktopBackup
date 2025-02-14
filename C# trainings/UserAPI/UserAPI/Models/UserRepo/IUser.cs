namespace UserAPI.Models.UserRepo
{
    public interface IUser
    {
        public Task<User> GetUserByIdAsync(int userId);
        public Task<IEnumerable<User>> GetAllUsersAsync();
        public Task AddUserAsync(User user);
        public Task UpdateUserAsync(User user);
        public Task<IEnumerable<User>> DeleteUserAsync(int userId);
    }
}
