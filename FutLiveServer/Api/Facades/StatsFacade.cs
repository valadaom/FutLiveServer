﻿using FutLiveServer.Facades.Interfaces;
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
        public async Task<List<StatsRetorno>> GetGols()
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
        public async Task<List<StatsRetorno>> GetAssists()
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
        public async Task<List<ClassificacaoRetorno>> GetClassificacao()
        {
            var nextPartidas = await _cartolaService.GetPartidas();
            var liClassificacao = new List<ClassificacaoRetorno>();
            foreach (var partida in nextPartidas.partidas)
            {
                var classificacaoCasa = new ClassificacaoRetorno
                {
                    clube_image = GetTeamFotoById(partida.clube_casa_id.ToString()),
                    clube_nome = GetTeamNameById(partida.clube_casa_id.ToString()),
                    clube_posicao = partida.clube_casa_posicao
                };
                var classificacaoFora = new ClassificacaoRetorno
                {
                    clube_image = GetTeamFotoById(partida.clube_visitante_id.ToString()),
                    clube_nome = GetTeamNameById(partida.clube_visitante_id.ToString()),
                    clube_posicao = partida.clube_visitante_posicao
                };
                liClassificacao.Add(classificacaoCasa);
                liClassificacao.Add(classificacaoFora);
            }
            return FilterClassificacao(liClassificacao);
        }
        public async Task<List<StatsRetorno>> GetSaldoGols()
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
                    Scout = "Sem sofrer gols",
                    Quantidade = atleta.scout.SG,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetFaltaSofrida()
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
                    Scout = "Faltas sofridas",
                    Quantidade = atleta.scout.FS,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetFinalizacaoFora()
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
                    Scout = "Finalizações para fora",
                    Quantidade = atleta.scout.FF,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetFinalizacaoDefendida()
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
                    Scout = "Finalizações defendidas",
                    Quantidade = atleta.scout.FD,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetFinalizacaoTrave()
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
                    Scout = "Finalizações na trave",
                    Quantidade = atleta.scout.FT,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetPenaltySofrido()
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
                    Scout = "Penaltis sofridos",
                    Quantidade = atleta.scout.PS,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetDefesaPenalti()
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
                    Scout = "Defesas penalti",
                    Quantidade = atleta.scout.DP,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetGolContra()
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
                    Scout = "Gols contra",
                    Quantidade = atleta.scout.GC,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetCartaoVermelho()
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
                    Scout = "Cartões vermelhos",
                    Quantidade = atleta.scout.CV,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetCartoesAmarelos()
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
                    Scout = "Cartões amarelos",
                    Quantidade = atleta.scout.CA,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetGolsSofridos()
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
                    Scout = "Gols sofridos",
                    Quantidade = atleta.scout.GS,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetPenaltiPerdido()
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
                    Scout = "Penaltis perdidos",
                    Quantidade = atleta.scout.PP,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetPenaltiCometido()
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
                    Scout = "Penaltis cometidos",
                    Quantidade = atleta.scout.PC,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetFaltasCometidas()
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
                    Scout = "Falta cometida",
                    Quantidade = atleta.scout.FC,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetImpedimento()
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
                    Scout = "Impedimentos",
                    Quantidade = atleta.scout.I,
                    clube_image = GetTeamFotoById(atleta.clube_id.ToString())
                };
                ranking.Add(jogador);
            }

            return FilterScouts(ranking);
        }
        public async Task<List<StatsRetorno>> GetPassesIncompletos()
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
                    Scout = "Passe incompleto",
                    Quantidade = atleta.scout.PI,
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
        private List<ClassificacaoRetorno> FilterClassificacao(List<ClassificacaoRetorno> ranking)
        {
            List<ClassificacaoRetorno> orderedList = ranking.OrderBy(i => i.clube_posicao).ToList();

            return orderedList;
        }

    }
}
