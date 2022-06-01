using FutLiveServer.DbService.Interfaces;
using FutLiveServer.Facades.Interfaces;
using FutLiveServer.Models;
using FutLiveServer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FutLiveServer.Facades
{
    public class RodadaFacade : IRodadaFacade
    {
        private readonly ICartolaService _cartolaService;
        public RodadaFacade(ICartolaService cartolaService)
        {
            _cartolaService = cartolaService;
        }
        public async Task<LastGamesRetorno> GetNextGames()
        {
            var nextPartidas = await _cartolaService.GetPartidas();

            var jogosUltimaRodada = await _cartolaService.GetRodada(nextPartidas.rodada + 1);

            var partidasRecentes = new List<Partidas>();

            foreach (var item in jogosUltimaRodada.partidas)
            {
                var partida = new Partidas
                {
                    time_casa_nome = GetTeamNameById(item.clube_casa_id.ToString()),
                    time_casa_foto = GetTeamFotoById(item.clube_casa_id.ToString()),
                    time_casa_resultado = "0",
                    time_fora_nome = GetTeamNameById(item.clube_visitante_id.ToString()),
                    time_fora_foto = GetTeamFotoById(item.clube_casa_id.ToString()),
                    time_fora_resultado = "0"
                };
                partidasRecentes.Add(partida);
            }
            return new LastGamesRetorno
            {
                partidas = partidasRecentes
            };
        }
        public async Task<LastGamesRetorno> GetLastGames()
        {
            var nextPartidas = await _cartolaService.GetPartidas();

            var jogosUltimaRodada = await _cartolaService.GetRodada(nextPartidas.rodada - 1);

            var partidasRecentes = new List<Partidas>();

            foreach (var item in jogosUltimaRodada.partidas)
            {
                var partida = new Partidas
                {
                    time_casa_nome = GetTeamNameById(item.clube_casa_id.ToString()),
                    time_casa_foto = GetTeamFotoById(item.clube_casa_id.ToString()),
                    time_casa_resultado = item.placar_oficial_mandante.ToString(),
                    time_fora_nome = GetTeamNameById(item.clube_visitante_id.ToString()),
                    time_fora_foto = GetTeamFotoById(item.clube_casa_id.ToString()),
                    time_fora_resultado = item.placar_oficial_visitante.ToString()
                };
                partidasRecentes.Add(partida);
            }
            return new LastGamesRetorno
            {
                partidas = partidasRecentes
            };
        }
        public async Task<LastGamesRetorno> GetGamesByRodada(int rodada)
        {
            var jogosUltimaRodada = await _cartolaService.GetRodada(rodada);

            var partidasRecentes = new List<Partidas>();

            foreach (var item in jogosUltimaRodada.partidas)
            {
                var partida = new Partidas
                {
                    time_casa_nome = GetTeamNameById(item.clube_casa_id.ToString()),
                    time_casa_foto = GetTeamFotoById(item.clube_casa_id.ToString()),
                    time_casa_resultado = Convert.ToString(item.placar_oficial_mandante ?? "0"),
                    time_fora_nome = GetTeamNameById(item.clube_visitante_id.ToString()),
                    time_fora_foto = GetTeamFotoById(item.clube_casa_id.ToString()),
                    time_fora_resultado = Convert.ToString(item.placar_oficial_visitante ?? "0")
                };
                partidasRecentes.Add(partida);
            }
            return new LastGamesRetorno
            {
                partidas = partidasRecentes
            };
        }

        private string GetTeamNameById(string id)
        {
            switch (id)
            {
                case ("262"):
                    return "Flamengo";
                case ("263"):
                    return "Botafogo";
                case ("264"):
                    return "Corinthians";
                case ("266"):
                    return "Fluminense";
                case ("275"):
                    return "Palmeiras";
                case ("276"):
                    return "São Paulo";
                case ("277"):
                    return "Santos";
                case ("280"):
                    return "Bragantino";
                case ("282"):
                    return "Atlético-MG";
                case ("285"):
                    return "Internacional";
                case ("286"):
                    return "Juventude";
                case ("290"):
                    return "Goiás";
                case ("293"):
                    return "Athlético-PR";
                case ("294"):
                    return "Coritiba";
                case ("314"):
                    return "Avaí";
                case ("327"):
                    return "América-MG";
                case ("354"):
                    return "Ceará";
                case ("356"):
                    return "Fortaleza";
                case ("373"):
                    return "Atlético-GO";
                case ("1371"):
                    return "Cuiabá";
            }
            return null;
        }
        private string GetTeamFotoById(string id)
        {
            switch (id)
            {
                case ("262"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2018/04/09/Flamengo-45.png";
                case ("263"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2019/02/04/botafogo-45.png";
                case ("264"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2019/09/30/Corinthians_45.png";
                case ("266"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2014/04/14/fluminense_45x45.png";
                case ("275"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2014/04/14/palmeiras_45x45.png";
                case ("276"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2014/04/14/sao_paulo_45x45.png";
                case ("277"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2014/04/14/santos_45x45.png";
                case ("280"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2020/01/01/45.png";
                case ("282"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2017/11/23/Atletico-Mineiro-escudo45px.png";
                case ("285"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2016/05/03/inter45.png";
                case ("286"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2021/04/29/juventude45.png";
                case ("290"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2021/03/01/goias-45.png";
                case ("293"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2019/09/09/Athletico-PR-45x45.png";
                case ("294"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2017/03/29/coritiba45.png";
                case ("314"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2018/09/04/escudo-avai-45x45.png";
                case ("327"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2019/02/28/escudo45_1.png";
                case ("354"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2019/10/10/ceara-45x45.png";
                case ("356"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2021/09/19/45_0000_Fortaleza-2021.png";
                case ("373"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2020/07/02/atletico-go-2020-45.png";
                case ("1371"):
                    return "https://s.glbimg.com/es/sde/f/organizacoes/2014/04/16/cuiaba45.png";
            }
            return null;
        }
    }
}
