using System;
using System.Collections.Generic;
using System.Linq;

namespace max_profit
{
    class Program
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices == default(int[]) || prices.Length <= 1)
            {
                return 0;
            }

            int maxProfit = 0;
            int buyPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < buyPrice)
                {
                    buyPrice = prices[i];
                }

                maxProfit = Math.Max(maxProfit, prices[i] - buyPrice);
            }

            return maxProfit;
        }

        static void Main(string[] args)
        {
            int[] prices = { 7, 6, 4, 3, 1 };
            int profit = MaxProfit(prices);
        }
    }
}
