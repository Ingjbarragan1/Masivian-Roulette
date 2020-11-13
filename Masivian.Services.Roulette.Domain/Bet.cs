using System;
using System.Collections.Generic;
using System.Text;
using Masivian.Services.Roulette.Domain.Enums;

namespace Masivian.Services.Roulette.Domain
{
    public class Bet
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public BetColor Color { get; set; }

        public double Money { get; set; }

        public User User { get; set; }
    }
}
