using System;
using System.Text;

namespace test123
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            Player p1 = new Player("John");
            Player p2 = new Player("Alice");

            p1.TakeCards(deck);
            p2.TakeCards(deck);
            
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Card[] cards = new Card[7];

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = deck.GetCard();
            }

            CombinationChecker.CheckKicker(cards);
        }
    }
}
