using ERP.Domain.Entity;
using ERP.Domain.UnitOfWork;
using ERP.Repository.Context;

namespace ERP.WebAPI.Services.AccountServices
{
    public class UserServiceApi : IUserServiceApi
    {
        private readonly IErpUnitOfWork _erpUnitOfWork;
        private readonly UserContext _userContext;

        public UserServiceApi(IErpUnitOfWork erpUnitOfWork, UserContext userContext)
        {
            _erpUnitOfWork = erpUnitOfWork;
            _userContext = userContext;
        }

        public async Task<User> FindByNameAsync(string username)
        {
            User user = await _erpUnitOfWork.Repository<User>().GetAsync(u => u.LoginName == username);
            return user;
        }

        public async Task<User> FindByCredentialAsync(string username, string password)
        {
            // Hash the password here
            User user = await _erpUnitOfWork.Repository<User>().GetAsync(u => u.LoginName == username && u.PASsword == password);
            return user;
        }

        public async Task<IEnumerable<string>> GetRolesAsync(User user)
        {
            // I'm taking the entire user object here  because I might need more information about the user in the future
            // Like I wanna see the hashed password or something


            // I won't use this way because the GetListAsync method will return the entire role object
            // I just need the role name
            var roles = (await _erpUnitOfWork.Repository<Role>().GetListAsync(r => r.Assignments.Any(u => u.UserGUID == user.GUID))).Select(x => x.Name);
            return roles;
        }
    }
}
