using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_1_Arrays_and_Strings
{
    //    String Compression: Implement a method to perform basic string compression using the counts
    //of repeated characters.For example, the string aabcccccaaa would become a2blc5a3.If the
    //"compressed" string would not become smaller than the original string, your method should return
    //the original string. You can assume the string has only uppercase and lowercase letters (a - z).
    public class _1_6 
    {
        public string CompressString(string a)
        {
            var chars = a.ToCharArray();
            var result = "";
            var count = 0;
            var currentChar = ""; 

            for (int i = 0; i < chars.Length; i++)
            {
                if (currentChar != chars[i].ToString())
                {
                    if (result != "")
                    {
                        result += count;
                        count = 0;
                    }
                    result += chars[i];
                    currentChar = chars[i].ToString();
                    count++;
                }
                else
                {
                    count++;
                }
            }

            result += count;

            return a.Length > result.Length ? result : a;
        }

        public string CompressString_V2(string a)
        {
            var result = "";
            var count = 0;
            //var currentChar = "";

            for (int i = 0; i <a.Length; i++)
            {
                count++;

                if(i+1 >= a.Length || a[i+1] != a[i])
                {
                    result += a[i] + count;
                    count = 0;
                }
            }

            return a.Length > result.Length ? result : a;
        }

        public string CompressString_V3(string a)
        {
            var builder = new StringBuilder();

            var count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                count++;

                if (i + 1 >= a.Length || a[i + 1] != a[i])
                {
                    builder.Append(a[i]);
                    builder.Append(count);
                    count = 0;
                }
            }

            return a.Length > builder.Length ? builder.ToString() : a;
        }
    }
}
