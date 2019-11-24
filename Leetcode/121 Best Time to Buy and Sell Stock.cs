using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _121_Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {

            // Brute force
            // O(N^2)
            var max = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                for (var j = i + 1; j < prices.Length; j++)
                {
                    max = Math.Max(prices[j] - prices[i], max);
                }
            }

            return max;
        }

        // One pass
        // O(N)
        public int MaxProfit(int[] prices)
        {

            var maxProfit = 0;

            if (prices == null || prices.Length == 0)
            {
                return maxProfit;
            }

            var min = prices[0];

            for (var i = 0; i < prices.Length; i++)
            {

                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else if (prices[i] - min > maxProfit)
                {
                    maxProfit = prices[i] - min;
                }
            }

            return maxProfit;
        }
    }
}
