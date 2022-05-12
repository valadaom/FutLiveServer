using FutLiveServer.Models;
using System.Threading.Tasks;

namespace FutLiveServer.Facades.Interfaces
{
    public interface IUserFacade
    {
        public Task<UserResponse> Login(string email, string password);
        public Task<UserResponse> Register(User user);
    }
}
