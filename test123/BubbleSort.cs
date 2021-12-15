using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    public static class BubbleSort
    {
        public static void SortByRank(Card[] sortArr)
        {
            for (int i = 0; i < sortArr.Length; i++)
            {
                for (int j = 0; j < sortArr.Length; j++)
                {
                    if (sortArr[i].Rank > sortArr[j].Rank)
                    {
                        Card temp = sortArr[i];
                        sortArr[i] = sortArr[j];
                        sortArr[j] = temp;
                    }
                }
            }
        }
    }
}
