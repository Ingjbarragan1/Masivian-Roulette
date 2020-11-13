using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Masivian.Servises.Roulette.Core
{
    
    public class RouletteService : IRouletteService 
    {
        private readonly IDistributedCache _distributedCache;

        public RouletteService(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public async Task<int> CreateRoulette() { return 0; }
        public async Task<string> OpenRoulette(int idRoulette) { return ""; }
        public async Task<int> CloseRoulette(int idRoulette) { return 0; }
    }
}
