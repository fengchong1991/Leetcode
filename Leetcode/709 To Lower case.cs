using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{

    // Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.

    // Example 1:

    // Input: "Hello"
    // Output: "hello"
    // Example 2:

    // Input: "here"
    // Output: "here"
    // Example 3:

    // Input: "LOVELY"
    // Output: "lovely"

    public class _709_To_Lower
    {
        public string ToLowerCase(string str)
        {
            var start = (int)'A';
            var end = (int)'Z';
            var offset = 'a' - 'A';

            var builder = new StringBuilder();
            foreach(var s in str)
            {
                if((int)s >= start && (int)s<=end)
                {
                    builder.Append((char)((int)s+offset));
                }
                else{
                    builder.Append(s);
                }
            }

            return builder.ToString();    
        }
    }
}