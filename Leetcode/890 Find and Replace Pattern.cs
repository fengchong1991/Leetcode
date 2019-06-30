using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _890_Find_and_Replace_Pattern
    {
        // Running time: O(N*M), N words, M characters average per word
        // Space: O(N*M)
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {

            var result = new List<string>();

            foreach (var word in words)
            {
                var map = new Dictionary<char, char>();
                var match = true;
                for (var i = 0; i < word.Length; i++)
                {
                    if (map.ContainsKey(pattern[i]))
                    {
                        if (map[pattern[i]] != word[i])
                        {
                            match = false;
                            break;
                        }
                    }
                    else
                    {
                        map.Add(pattern[i], word[i]);
                    }
                }

                var booleanArray = new bool[26];

                // Check if the mapped value has appeared more than once. Do not add the word if so
                foreach (var key in map.Values)
                {
                    if (booleanArray[key - 'a'] == false)
                    {
                        booleanArray[key - 'a'] = true;
                    }
                    else
                    {
                        match = false;
                    }
                }

                if (match)
                {
                    result.Add(word);
                }
            }

            return result;
        }
    }
}
