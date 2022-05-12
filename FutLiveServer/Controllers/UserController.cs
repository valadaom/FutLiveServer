using FutLiveServer.Facades.Interfaces;
using FutLiveServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FutLiveServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserFacade _userFacade;

        public UserController(IUserFacade userFacade)
        {
            _userFacade = userFacade;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            var result = await _userFacade.Login(email, password);

            if (result.Status != null && result.Status.Equals(Constants.STATUS_OK))
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            var result = await _userFacade.Register(user);

            if (result.Status.Equals(Constants.STATUS_OK))
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
