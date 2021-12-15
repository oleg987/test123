using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    public static class CombinationChecker
    {
        public static void CheckCombination(Card[] common, Card[] playerCards)
        {
            Card[] cards = new Card[common.Length + playerCards.Length];

            Array.Copy(common, cards, common.Length);
            Array.Copy(playerCards, 0, cards, common.Length, playerCards.Length);

            var combination = CheckKicker(cards);
        }

        public static Card[] CheckKicker(Card[] cards)
        {
            BubbleSort.SortByRank(cards);

            Card[] result = new Card[5];

            Array.Copy(cards, result, 5);

            return result;
        }

        public static Card[] CheckPair(Card[] cards)
        {
            Card[] result = new Card[5];

            BubbleSort.SortByRank(cards);

            for (int i = 0; i < cards.Length - 1; i++)
            {
                if (cards[i].Rank == cards[i + 1].Rank)
                {
                    result[0] = cards[i];
                    result[1] = cards[i + 1];
                }
            }

            return result;
        }

    }
}
