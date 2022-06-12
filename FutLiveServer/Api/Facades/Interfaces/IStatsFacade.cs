using FutLiveServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FutLiveServer.Facades.Interfaces
{
    public interface IStatsFacade
    {
        public Task<List<StatsRetorno>> GetGols();
        public Task<List<StatsRetorno>> GetAssists();
        public Task<List<StatsRetorno>> GetDesarmes();
        public Task<List<StatsRetorno>> GetDefesas();
        public Task<List<ClassificacaoRetorno>> GetClassificacao();
        public Task<List<StatsRetorno>> GetSaldoGols();
        public Task<List<StatsRetorno>> GetFaltaSofrida();
        public Task<List<StatsRetorno>> GetFinalizacaoFora();
        public Task<List<StatsRetorno>> GetFinalizacaoDefendida();
        public Task<List<StatsRetorno>> GetFinalizacaoTrave();
        public Task<List<StatsRetorno>> GetPenaltySofrido();
        public Task<List<StatsRetorno>> GetDefesaPenalti();
        public Task<List<StatsRetorno>> GetGolContra();
        public Task<List<StatsRetorno>> GetCartaoVermelho();
        public Task<List<StatsRetorno>> GetCartoesAmarelos();
        public Task<List<StatsRetorno>> GetGolsSofridos();
        public Task<List<StatsRetorno>> GetPenaltiPerdido();
        public Task<List<StatsRetorno>> GetPenaltiCometido();
        public Task<List<StatsRetorno>> GetFaltasCometidas();
        public Task<List<StatsRetorno>> GetImpedimento();
        public Task<List<StatsRetorno>> GetPassesIncompletos();
    }
}
