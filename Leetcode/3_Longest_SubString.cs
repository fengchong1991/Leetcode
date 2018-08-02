using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _3_Longest_SubString
    {
        /// <summary>
        /// Brutal force
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring_V1(string s)
        {
            var maxLength = 0;

            if(s.Length == 0)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    var currentLength = 0;
                    for (int j = 1; j + i < s.Length; j++)
                    {
                        if (!s.Substring(i, j).Contains(s[i + j]))
                        {
                            currentLength += 1;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
            }

            return maxLength + 1;
        }
    }
}
