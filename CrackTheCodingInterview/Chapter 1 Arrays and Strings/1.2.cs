using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_1_Arrays_and_Strings
{
    /// <summary>
    /// Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.
    /// </summary>
    public class _1_2
    {
        /// <summary>
        /// Sort the strings and compare chars one by one
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsPermutation(string a, string b)
        {
            if(a.Length != b.Length)
            {
                return false;
            }
            var aCharSet = a.ToCharArray();
            var bCharSet = b.ToCharArray();

            Array.Sort(aCharSet);
            Array.Sort(bCharSet);

            return aCharSet.SequenceEqual(bCharSet);
        }

        /// <summary>
        /// Check if two strings have same set of chars and number of occurrences are the same
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsPermutation_V2(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            var aDic = new Dictionary<char, int>();
            var bDic = new Dictionary<char, int>();

            foreach (var aChar in a)
            {
                if (aDic.ContainsKey(aChar))
                {
                    aDic[aChar] = aDic[aChar]++;
                }
                else
                {
                    aDic.Add(aChar, 1);
                }
            }

            foreach (var bChar in b)
            {
                if (bDic.ContainsKey(bChar))
                {
                    bDic[bChar] = bDic[bChar]++;
                }
                else
                {
                    bDic.Add(bChar, 1);
                }
            }

            if(aDic.Count() != bDic.Count()) {
                return false;
            }

            foreach (var entry in aDic)
            {
                if(!bDic.ContainsKey(entry.Key))
                {
                    return false;
                }
                else if (bDic[entry.Key] != entry.Value)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Convert to ASCII
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsPermutation_V3(string a, string b)
        {
            if(a.Length != b.Length)
            {
                return false;
            }

            var letters = new int[128];

            var aCharArray = a.ToCharArray();

            foreach(var aChar in a)
            {
                int code = aChar;
                letters[code]++;
            }

            foreach(var bChar in b)
            {
                int code = bChar;
                letters[code]--;
                if(letters[code] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
