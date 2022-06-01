using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutLiveServer.Models
{
    public class LastGamesRetorno
    {
        public List<Partidas> partidas { get; set; }
    }

    public class Partidas
    {
        public string time_casa_nome { get; set; }
        public string time_casa_foto { get; set; }
        public string time_casa_resultado { get; set; }
        public string time_fora_nome { get; set; }
        public string time_fora_foto { get; set; }
        public string time_fora_resultado { get; set; }
    }
}
