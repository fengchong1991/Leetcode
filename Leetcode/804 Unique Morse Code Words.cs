﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //    International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

    //For convenience, the full table for the 26 letters of the English alphabet is given below:

    //[".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
    //    Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter.For example, "cba" can be written as "-.-.-....-", (which is the concatenation "-.-." + "-..." + ".-"). We'll call such a concatenation, the transformation of a word.

    //Return the number of different transformations among all words we have.

    //Example:
    //Input: words = ["gin", "zen", "gig", "msg"]
    //    Output: 2
    //Explanation: 
    //The transformation of each word is:
    //"gin" -> "--...-."
    //"zen" -> "--...-."
    //"gig" -> "--...--."
    //"msg" -> "--...--."

    //There are 2 different transformations, "--...-." and "--...--.".
    //Note:

    //The length of words will be at most 100.
    //Each words[i] will have length in range[1, 12].
    //words[i] will only consist of lowercase letters.
    
    //Time complexity is O(N), N represents the sum of the length of the words
    //Space complexity is O(N)
    public class Solution
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            var alphabets = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            var result = new HashSet<string>();

            foreach (var word in words)
            {
                var sb = new StringBuilder();

                foreach (var cha in word)
                {
                    sb.Append(alphabets[cha - 'a']);
                }

                result.Add(sb.ToString());
            }

            return result.Count;
        }
    }
}

