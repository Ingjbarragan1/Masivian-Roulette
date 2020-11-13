using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Masivian.Servises.Roulette.Core
{
    public interface IRouletteService
    {
        Task<int> CreateRoulette();
        Task<string> OpenRoulette(int idRoulette);        
        Task<int> CloseRoulette(int idRoulette);
    }
}
