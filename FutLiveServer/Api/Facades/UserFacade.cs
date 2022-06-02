using FutLiveServer.DbService.Interfaces;
using FutLiveServer.Facades.Interfaces;
using FutLiveServer.Models;
using System.Threading.Tasks;

namespace FutLiveServer.Facades
{
    public class UserFacade : IUserFacade
    {
        private readonly IDbService _dbService;
        public UserFacade(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<UserResponse> Login(string email, string password)
        {
            var userResponse = await _dbService.LoginAsync(email, password);

            if (!string.IsNullOrEmpty(userResponse.Name))
            {
                userResponse.Status = Constants.STATUS_OK;
            }
            else
            {
                userResponse.Status = Constants.WRONG_CREDENTIALS;
            }

            return userResponse;
        }
        public async Task<UserResponse> Register(User user)
        {
            var userResponse = await _dbService.RegisterAsync(user);

            if (!string.IsNullOrEmpty(userResponse.Name))
            {
                userResponse.Status = Constants.STATUS_OK;
            }
            else
            {
                userResponse.Status = Constants.REGISTER_FAIL;
            }

            return userResponse;
        }
    }
}
