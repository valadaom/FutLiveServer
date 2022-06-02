using FutLiveServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FutLiveServer.Facades.Interfaces
{
    public interface IStatsFacade
    {
        public Task<List<StatsRetorno>> GetArtilheiros();
        public Task<List<StatsRetorno>> GetGarçons();
        public Task<List<StatsRetorno>> GetDesarmes();
        public Task<List<StatsRetorno>> GetDefesas();
    }
}
