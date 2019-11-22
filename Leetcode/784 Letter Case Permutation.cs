using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _784_Letter_Case_Permutation
    {
        // Running time O(N*2^N)
        public IList<string> LetterCasePermutation(string S)
        {

            var permutation = new List<string>();

            permutation.Add(S);

            for (var i = 0; i < S.Length; i++)
            {

                if (char.IsLetter(S[i]))
                {

                    var length = permutation.Count;

                    for (var j = 0; j < length; j++)
                    {

                        var charArray = permutation[j].ToCharArray();

                        if (char.IsLower(charArray[i]))
                        {
                            charArray[i] = char.ToUpper(charArray[i]);
                        }
                        else
                        {
                            charArray[i] = char.ToLower(charArray[i]);
                        }

                        permutation.Add(new string(charArray));
                    }
                }
            }

            return permutation;
        }

    }
}
