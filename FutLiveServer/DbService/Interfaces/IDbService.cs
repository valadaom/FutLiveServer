using FutLiveServer.Models;
using System.Threading.Tasks;

namespace FutLiveServer.DbService.Interfaces
{
    public interface IDbService
    {
        public Task<UserResponse> LoginAsync(string email, string password);
        public Task<UserResponse> RegisterAsync(User user);
    }
}
