using ERP.Domain.Entity;

namespace ERP.WebAPI.Services.AccountServices
{
    public interface IUserServiceApi
    {
        Task<User> FindByCredentialAsync(string username, string password);
        Task<User> FindByNameAsync(string username);
        Task<IEnumerable<string>> GetRolesAsync(User user);
    }
}