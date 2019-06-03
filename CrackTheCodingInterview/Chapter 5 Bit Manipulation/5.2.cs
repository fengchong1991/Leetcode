using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_5_Bit_Manipulation
{
    public class _5_2
    {
        //
        //        Binary to String: Given a real number between 0 and 1 (e.g., 0.72) that is passed in as a double,
        //print the binary representation.If the number cannot be represented accurately in binary with at
        //most 32 characters, print"ERROR:

        
        // Mutiply the number by two and compare it with 1
        public string BinaryToString(double number)
        {
            if(number >= 1 || number <= 0)
            {
                Console.WriteLine("error");
            }

            StringBuilder binary = new StringBuilder();

            binary.Append(".");

            while(number > 0)
            {
                if(binary.Length >= 32)
                {
                    Console.WriteLine("error");
                }

                var r = number * 2;
                if(r >= 1)
                {
                    binary.Append("1");
                    number = r - 1;
                }
                else
                {
                    binary.Append("0");
                    number = r;
                }
            }

            return binary.ToString();
        }

        // Compare the number with 0.5, 0.25, 0.125...
        public string BinaryToString_V2(double number)
        {
            if(number >= 1 | number <= 0)
            {
                Console.WriteLine("Error");
            }

            StringBuilder sb = new StringBuilder();

            sb.Append('.');

            var step = 0.5;
            while(number > 0)
            {
                if(sb.Length >= 32)
                {
                    Console.WriteLine("error");
                }

                if(number > step)
                {
                    sb.Append(1);
                    number -= step;
                }
                else
                {
                    sb.Append(0);
                }

                step = step / 2;
            }

            return sb.ToString();
        }
    }
}
