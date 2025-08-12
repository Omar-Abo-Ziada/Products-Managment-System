namespace ProductsMangementSystem.Common.Repositories.Users
{
    public interface IUserRepository : IRepository<User>
    {
        Task<bool> EmailIsExistAsync(string email);
        Task<User> GetByUsernameAsync(string username);
        Task<bool> UsernameIsExistAsync(string username);
    }
}
