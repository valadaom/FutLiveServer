using FutLiveServer.Models;
using System.Threading.Tasks;

namespace FutLiveServer.Facades.Interfaces
{
    public interface IRodadaFacade
    {
        public Task<LastGamesRetorno> GetLastGames();
        public Task<LastGamesRetorno> GetNextGames();
        public Task<LastGamesRetorno> GetGamesByRodada(int rodada);
    }
}
