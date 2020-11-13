using Masivian.Servises.Roulette.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masivian.Services.Roulette.Web
{
    public class RouletteController 
    {
        private readonly IRouletteService _rouletteService;
        private readonly IBetService _betService;
       

        public RouletteController(IRouletteService rouletteService, IBetService betService)
        {
            _rouletteService = rouletteService;
            _betService = betService;
        }

        public async Task<IActionResult> createRoulette()
        {
            return createRoulette();
        }

    }
}
