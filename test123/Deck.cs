using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    public class Deck
    {
        private Card[] _cards;
        private int _counter;

        public Deck()
        {
            _cards = new Card[52];
            _counter = 0;

            int counter = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    _cards[counter] = new Card(j, i);
                    counter++;
                }
            }

            Random rnd = new Random();

            for (int i = 0; i < _cards.Length; i++)
            {
                var index = rnd.Next(_cards.Length);

                Card card = _cards[index];
                _cards[index] = _cards[i];
                _cards[i] = card;
            }
        }

        public Card GetCard()
        {
            if (_counter >= 52)
            {
                throw new Exception("No cards in deck.");
            }

            Card card = _cards[_counter];
            _counter++;

            return card;
        }
    }
}
