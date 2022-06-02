using FutLiveServer.Facades.Interfaces;
using FutLiveServer.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FutLiveServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RodadaController : ControllerBase
    {
        private readonly IRodadaFacade _rodadaFacade;

        public RodadaController(IRodadaFacade rodadaFacade)
        {
            _rodadaFacade = rodadaFacade;
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("lastgames")]
        public async Task<IActionResult> GetLastGames()
        {
            var result = await _rodadaFacade.GetLastGames();

            if (result.partidas.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("nextgames")]
        public async Task<IActionResult> GetNextGames()
        {
            var result = await _rodadaFacade.GetNextGames();

            if (result.partidas.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("{rodada}")]
        public async Task<IActionResult> GetGamesByRodada(int rodada)
        {
            var result = await _rodadaFacade.GetGamesByRodada(rodada);

            if (result.partidas.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
