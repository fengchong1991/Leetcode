using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview
{
    /// <summary>
    /// Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you
    /// cannot use additional data structures?
    /// </summary>
    public class _1_1
    {
        public bool IsStringAllCharsUnique(string str)
        {
            var charHashTable = new HashSet<char>();

            foreach(var c in str)
            {
                if (charHashTable.Contains(c))
                {
                    return false;
                }
                else
                {
                    charHashTable.Add(c);
                }
            }

            return true;
        }

        public bool IsStringAllCharsUnique_Array(string str)
        {
            bool[] charSet = new bool[128];

            for (int i = 0;  i < str.Length; i++)
            {
                int val = str[i];
                if (charSet[val])
                {
                    return false;
                }
                charSet[val] = true;
            }

            return true;
        }
    }
}
