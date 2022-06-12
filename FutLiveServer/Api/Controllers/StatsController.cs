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
        public async Task<IActionResult> GetGols()
        {
            var result = await _statsFacade.GetGols();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("garçons")]
        public async Task<IActionResult> GetAssists()
        {
            var result = await _statsFacade.GetAssists();

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

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("saldo_gol")]
        public async Task<IActionResult> GetSaldoGols()
        {
            var result = await _statsFacade.GetSaldoGols();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("falta_sofrida")]
        public async Task<IActionResult> GetFaltaSofrida()
        {
            var result = await _statsFacade.GetFaltaSofrida();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("finalizacao_fora")]
        public async Task<IActionResult> GetFinalizacaoFora()
        {
            var result = await _statsFacade.GetFinalizacaoFora();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("finalizacao_defendida")]
        public async Task<IActionResult> GetFinalizacaoDefendida()
        {
            var result = await _statsFacade.GetFinalizacaoDefendida();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("finalizacao_trave")]
        public async Task<IActionResult> GetFinalizacaoTrave()
        {
            var result = await _statsFacade.GetFinalizacaoTrave();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("penalti_sofrido")]
        public async Task<IActionResult> GetPenaltySofrido()
        {
            var result = await _statsFacade.GetPenaltySofrido();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("defesa_penalti")]
        public async Task<IActionResult> GetDefesaPenalti()
        {
            var result = await _statsFacade.GetDefesaPenalti();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("gol_contra")]
        public async Task<IActionResult> GetGolContra()
        {
            var result = await _statsFacade.GetGolContra();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("cartao_vermelho")]
        public async Task<IActionResult> GetCartaoVermelho()
        {
            var result = await _statsFacade.GetCartaoVermelho();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("cartao_amarelo")]
        public async Task<IActionResult> GetCartoesAmarelos()
        {
            var result = await _statsFacade.GetCartoesAmarelos();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("gol_sofrido")]
        public async Task<IActionResult> GetGolsSofridos()
        {
            var result = await _statsFacade.GetGolsSofridos();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("penalti_perdido")]
        public async Task<IActionResult> GetPenaltiPerdido()
        {
            var result = await _statsFacade.GetPenaltiPerdido();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("penalti_cometido")]
        public async Task<IActionResult> GetPenaltiCometido()
        {
            var result = await _statsFacade.GetPenaltiCometido();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("falta_cometida")]
        public async Task<IActionResult> GetFaltasCometidas()
        {
            var result = await _statsFacade.GetFaltasCometidas();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("impedimento")]
        public async Task<IActionResult> GetImpedimento()
        {
            var result = await _statsFacade.GetImpedimento();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("passe_incompleto")]
        public async Task<IActionResult> GetPassesIncompletos()
        {
            var result = await _statsFacade.GetPassesIncompletos();

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
