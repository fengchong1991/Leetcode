using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _961_N_Repeated_Element_in_Size_2N_Array
    {
        // Running time: O(N), N is the length of A
        // Space: O(N)
        public class Solution
        {
            public int RepeatedNTimes(int[] A)
            {
                var diction = new Dictionary<int, int>();

                foreach (var i in A)
                {
                    if (diction.ContainsKey(i))
                    {
                        diction[i] = ++diction[i];
                    }
                    else
                    {
                        diction[i] = 1;
                    }
                }

                int maxOccurence = 0;
                int key = 0;

                foreach (var pair in diction)
                {
                    if (pair.Value > maxOccurence)
                    {
                        maxOccurence = pair.Value;
                        key = pair.Key;
                    }
                }

                return key;
            }
        }

        // Running time: O(N), N is the length of A
        // Space: O(N)
        public int RepeatedNTimes(int[] A)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int a in A)
            {
                if (!set.Add(a))
                {
                    return a;
                }

            }
            return 0;
        }
    }
}
