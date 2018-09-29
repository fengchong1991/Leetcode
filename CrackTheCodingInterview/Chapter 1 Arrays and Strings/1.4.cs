using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_1_Arrays_and_Strings
{
    //    Palindrome Permutation: Given a string, write a function to check if it is a permutation of
    //a palindrome.A palindrome is a word or phrase that is the same forwards and backwards.A
    //permutation is a rearrangement of letters.The palindrome does not need to be limited to just
    //dictionary words.
    //EXAMPLE
    //Input: Tact Coa
    //Output: True (permutations: "taco cat'; "atc o eta·; etc.)
    public class _1_4
    {
        public bool IsPermutationOfPalindrome(string a)
        {
            var occurrenceDic = new Dictionary<char, int>();

            foreach(var aChar in a)
            {
                if (occurrenceDic.ContainsKey(aChar))
                {
                    occurrenceDic[aChar]++;
                }
                else
                {
                    occurrenceDic.Add(aChar, 1);
                }
            }

            int numberOfOdd = 0;

            foreach(var charOccurence in occurrenceDic)
            {
                if(charOccurence.Value %2 != 0)
                {
                    numberOfOdd++;

                    if(numberOfOdd > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
