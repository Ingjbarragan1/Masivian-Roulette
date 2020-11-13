using Masivian.Services.Roulette.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Masivian.Servises.Roulette.Core
{
    public interface IBetService
    {
        Task<int> CreateBet(int idRoulette, Bet bet);
    }
}
