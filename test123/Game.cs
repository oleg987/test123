using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    public class Game
    {
        private Deck _deck;

        public Player[] Players { get; set; }
        public Card[] Common { get; set; }

        public Game(Player[] players)
        {
            Players = players;
            _deck = new Deck();
            Common = new Card[5];
        }

        public void Start()
        {
            // Check players count.

            foreach (Player player in Players)
            {
                player.TakeCards(_deck);
            }

            for (int i = 0; i < Common.Length; i++)
            {
                Common[i] = _deck.GetCard();
            }
        }


    }
}
