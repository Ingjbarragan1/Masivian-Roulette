using System;
using System.Collections.Generic;
using System.Text;
using Masivian.Services.Roulette.Domain.Enums;


namespace Masivian.Services.Roulette.Domain
{
    public class Roulette
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public IEnumerable<Bet> Bets { get; set; }
        public Bet Winner { get; set; }


        public int SetStatus(int IdRoulette) {

            int result = 0;

            return result;
        }

    }

    
}
