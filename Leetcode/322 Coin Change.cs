using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterviewTests
{
    class _322_Coin_Change
    {
        // Brute Force
        public int CoinChange(int[] coins, int amount)
        {

            if (amount < 0)
            {
                return -1;
            }

            if (amount == 0)
            {
                return 0;
            }

            var min = int.MaxValue;

            for (var i = 0; i < coins.Length; i++)
            {

                var result = CoinChange(coins, amount - coins[i]);


                if (result != -1)
                {
                    min = Math.Min(min, result + 1);
                }
            }

            if (min == int.MaxValue)
            {
                min = -1;
            }

            return min;
        }
    }

        // Brute Force V2
        public int CoinChange(int[] coins, int amount)
        {

            return Change(coins, 0, amount, 0);
        }

        public int Change(int[] coins, int index, int sum, int count)
        {
            if (sum < 0 || index >= coins.Length)
            {
                return -1;
            }

            if (sum == 0)
            {
                return count;
            }

            var c1 = Change(coins, index, sum - coins[index], ++count);

            var c2 = Change(coins, index + 1, sum, --count);

            if (c1 != -1 && c2 != -1)
            {

                return Math.Min(c1, c2);
            }
            else
            {
                return c1 == -1 ? c2 : c1;
            }
        }

    // Top-down
    // Memorization
    public int CoinChange(int[] coins, int amount)
    {

        var dp = new int?[amount + 1];
        return Calculate(coins, amount, dp);
    }


    public int Calculate(int[] coins, int amount, int?[] dp)
    {

        if (amount < 0)
        {
            return -1;
        }

        if (amount == 0)
        {
            return 0;
        }

        if (dp[amount] != null)
        {
            return dp[amount].Value;
        }

        var min = int.MaxValue;

        for (var i = 0; i < coins.Length; i++)
        {

            var result = Calculate(coins, amount - coins[i], dp);

            if (result != -1)
            {
                min = Math.Min(min, result + 1);
            }
        }

        if (min == int.MaxValue)
        {
            min = -1;
        }

        dp[amount] = min;

        return min;
    }

    // Bottom-up
    public int CoinChange(int[] coins, int amount)
    {

        var dp = new int[amount + 1];

        dp[0] = 0;

        for (var i = 1; i < dp.Length; i++)
        {
            dp[i] = amount + 1;
        }

        for (var i = 0; i < dp.Length; i++)
        {
            for (var j = 0; j < coins.Length; j++)
            {

                if (coins[j] > i)
                {
                    continue;
                }
                dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}
