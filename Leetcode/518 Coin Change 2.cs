using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _518_Coin_Change_2
    {
        // Brute force
        public int Change(int amount, int[] coins)
        {

            if (amount == 0)
            {
                return 1;
            }

            return Compute(coins, 0, amount);
        }

        public int Compute(int[] coins, int index, int amount)
        {

            if (amount < 0 || index >= coins.Length)
            {
                return 0;
            }

            if (amount == 0)
            {
                return 1;
            }


            var combinations = 0;

            combinations += Compute(coins, index, amount - coins[index]);
            combinations += Compute(coins, index + 1, amount);

            return combinations;
        }


        // Top-down memorization
        public int Change(int amount, int[] coins)
        {

            var dp = new int?[coins.Length][];

            for (var i = 0; i < dp.Length; i++)
            {
                dp[i] = new int?[amount + 1];
            }


            if (amount == 0)
            {
                return 1;
            }


            return Compute(coins, dp, 0, amount);
        }

        public int Compute(int[] coins, int?[][] dp, int index, int amount)
        {

            if (amount < 0 || index >= coins.Length)
            {
                return 0;
            }

            if (amount == 0)
            {
                return 1;
            }

            if (dp[index][amount] == null)
            {
                var combinations = 0;
                combinations += Compute(coins, dp, index, amount - coins[index]);
                combinations += Compute(coins, dp, index + 1, amount);

                dp[index][amount] = combinations;
            }


            return dp[index][amount].Value;
        }
    }
}
