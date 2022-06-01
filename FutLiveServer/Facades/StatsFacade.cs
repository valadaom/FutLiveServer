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
                    Quantidade = atleta.scout.G
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


        private List<StatsRetorno> FilterScouts(List<StatsRetorno> ranking)
        {
            List<StatsRetorno> orderedList = ranking.OrderByDescending(i => i.Quantidade).ToList();

            return orderedList;
        }
    }
}
