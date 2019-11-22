using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _744_Find_Smallest_Letter_Greater_Than_Target
    {
        public char NextGreatestLetter(char[] letters, char target)
        {

            var start = 0;
            var end = letters.Length - 1;

            while (start <= end)
            {

                var mid = start + (end - start) / 2;

                if (target < letters[mid])
                {
                    end = mid - 1;
                }
                else if (target >= letters[mid])
                {
                    start = mid + 1;
                }
            }


            return letters[start % letters.Length];
        }
    }
}
