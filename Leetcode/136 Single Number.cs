using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _136_Single_Number
    {
        /// <summary>
        /// Use XOR to calculate
        /// A XOR A = 0
        /// A XOR 0 = A
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            var n = 0;

            foreach (var num in nums)
            {
                n = n ^ num;
            }

            return n;
        }
    }
}
