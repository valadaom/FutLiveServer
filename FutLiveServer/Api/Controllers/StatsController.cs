using FutLiveServer.Facades.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FutLiveServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatsController : ControllerBase
    {
        private readonly IStatsFacade _statsFacade;

        public StatsController(IStatsFacade statsFacade)
        {
            _statsFacade = statsFacade;
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("artilheiros")]
        public async Task<IActionResult> GetArtilheiros()
        {
            var result = await _statsFacade.GetArtilheiros();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("garçons")]
        public async Task<IActionResult> GetGarçons()
        {
            var result = await _statsFacade.GetGarçons();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("defesas")]
        public async Task<IActionResult> GetDefesas()
        {
            var result = await _statsFacade.GetDefesas();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("desarmes")]
        public async Task<IActionResult> GetDesarmes()
        {
            var result = await _statsFacade.GetDesarmes();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("classificacao")]
        public async Task<IActionResult> GetClassificacao()
        {
            var result = await _statsFacade.GetClassificacao();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
