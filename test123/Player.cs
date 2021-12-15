using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    public class Player
    {
        public string Name { get; set; }
        public Card[] Cards { get; set; }

        public Player(string name)
        {
            Name = name;
            Cards = new Card[2];
        }

        public void TakeCards(Deck deck)
        {
            for (int i = 0; i < 2; i++)
            {
                Cards[i] = deck.GetCard();
            }
        }

        public override string ToString()
        {
            return $"{Name} {Cards[0]} {Cards[1]}";
        }
    }
}
