using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    public class Card
    {
        public int Rank { get; set; }
        public int Suit { get; set; }

        public Card(int rank, int suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Rank} - {Suit}";
        }
    }
}
