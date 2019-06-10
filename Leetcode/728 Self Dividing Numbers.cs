using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _728_Self_Dividing_Numbers
    {
        // Running time: O(N)
        // Space: O(N), the list to return the answer
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var result = new List<int>();


            for (var i = left; i <= right; i++)
            {
                var isSelfDividing = true;

                foreach (var num in i.ToString())
                {
                    if (num == '0' || i % (num - '0') != 0)
                    {
                        isSelfDividing = false;
                        break;
                    }
                }

                if (isSelfDividing)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
