using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _202_Happy_Number
    {
        public bool IsHappy(int n)
        {
            var slow = n;
            var fast = n;

            do
            {
                slow = CalSqureSum(slow);
                fast = CalSqureSum(CalSqureSum(fast));
            }
            while (slow != fast);

            return slow == 1;
        }


        public int CalSqureSum(int n)
        {

            var sum = 0;

            while (n > 0)
            {
                var remainder = n % 10;

                sum += remainder * remainder;

                n /= 10;
            }

            return sum;
        }
    }
}
 