using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _557_Reverse_Words_in_a_String_3
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(' ');
            var sb = new StringBuilder();

            for (var j = 0; j < words.Length; j++)
            {
                var charArray = words[j].ToCharArray();
                var length = charArray.Length;
                
                for (var i = 0; i < length / 2; i++)
                {
                    var tempChar = charArray[length - 1 - i];
                    charArray[length - 1 - i] = charArray[i];
                    charArray[i] = tempChar;
                }

                sb.Append(charArray);
                if (j < words.Length - 1)
                {
                    sb.Append(' ');
                }
            }

            return sb.ToString();
        }
    }
}
