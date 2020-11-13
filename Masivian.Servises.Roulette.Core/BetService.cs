using Masivian.Services.Roulette.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Masivian.Servises.Roulette.Core
{
    public class BetService : IBetService
    {
        public async Task<int> CreateBet(int idRoulette, Bet bet)
        {
            return 0;
        }
    }
}
