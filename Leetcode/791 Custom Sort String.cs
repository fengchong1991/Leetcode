
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _791_Custom_Sort_String
    {
        /// <summary>
        /// Running time O(s+t), Space O(1);
        /// </summary>
        /// <param name="S"></param>
        /// <param name="T"></param>
        /// <returns></returns>
        public string CustomSortString(string S, string T)
        {
            var charDic = new Dictionary<char, int>();
            var sb = new StringBuilder();

            foreach (var c in T)
            {
                if (charDic.ContainsKey(c))
                {
                    charDic[c]++;
                }
                else
                {
                    charDic[c] = 1;
                }
            }

            foreach (var c in S)
            {
                if (charDic.ContainsKey(c))
                {
                    var times = charDic[c];
                    for (var i = 0; i < times; i++)
                    {
                        sb.Append(c);
                    }
                    charDic[c] = 0;
                }
            }

            foreach (var c in charDic)
            {
                if (c.Value > 0)
                {
                    for (var i = 0; i < c.Value; i++)
                    {
                        sb.Append(c.Key);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
