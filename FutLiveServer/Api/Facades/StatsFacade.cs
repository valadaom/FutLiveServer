using FutLiveServer.Facades.Interfaces;
using FutLiveServer.Models;
using FutLiveServer.Services.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace FutLiveServer.Facades
{
    public class StatsFacade : IStatsFacade
    {
        private readonly ICartolaService _cartolaService;
        public StatsFacade(ICartolaService cartolaService)
        {
            _cartolaService = cartolaService;
        }
        public async Task<List<StatsRetorno>> GetArtilheiros()
        {
            var mercado = await _cartolaService.GetMercado();
            var ranking = new List<StatsRetorno>();
            foreach (var atleta in mercado.atletas)
            {
                var jogador = new StatsRetorno
                {
                    Nome = atleta.apelido,
                    Jogos = atleta.jogos_num,
                    Clube = GetTeamNameById(atleta.clube_id.ToString()),
                    Scout = "Gols",
                    Quantidade = atleta.scout.G,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetGarçons()
        {
            var mercado = await _cartolaService.GetMercado();
            var ranking = new List<StatsRetorno>();
            foreach (var atleta in mercado.atletas)
            {
                var jogador = new StatsRetorno
                {
                    Nome = atleta.apelido,
                    Jogos = atleta.jogos_num,
                    Clube = GetTeamNameById(atleta.clube_id.ToString()),
                    Scout = "Assistências",
                    Quantidade = atleta.scout.A,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetDesarmes()
        {
            var mercado = await _cartolaService.GetMercado();
            var ranking = new List<StatsRetorno>();
            foreach (var atleta in mercado.atletas)
            {
                var jogador = new StatsRetorno
                {
                    Nome = atleta.apelido,
                    Jogos = atleta.jogos_num,
                    Clube = GetTeamNameById(atleta.clube_id.ToString()),
                    Scout = "Desarmes",
                    Quantidade = atleta.scout.DS,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetDefesas()
        {
            var mercado = await _cartolaService.GetMercado();
            var ranking = new List<StatsRetorno>();
            foreach (var atleta in mercado.atletas)
            {
                var jogador = new StatsRetorno
                {
                    Nome = atleta.apelido,
                    Jogos = atleta.jogos_num,
                    Clube = GetTeamNameById(atleta.clube_id.ToString()),
                    Scout = "Defesas",
                    Quantidade = atleta.scout.DE,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
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


        private List<StatsRetorno> FilterScouts(List<StatsRetorno> ranking)
        {
            List<StatsRetorno> orderedList = ranking.OrderByDescending(i => i.Quantidade).ToList();

            return orderedList;
        }
    }
}
