using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _8_String_to_Integer
    {
        public int MyAtoi(string str)
        {

            var anwser = 0;
            var negative = false;
            var index = 0;

            while (index < str.Length && str[index] == ' ')
            {
                index++;
            }

            if (index < str.Length && (str[index] == '+' || str[index] == '-'))
            {

                negative = str[index] == '-';

                index++;
            }

            for (var i = index; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {

                    if ((int.MaxValue - (str[i] - '0')) / 10 < anwser)
                    {

                        return negative ? int.MinValue : int.MaxValue;
                    }

                    anwser = anwser * 10 + (str[i] - '0');
                }
                else
                {
                    return negative ? -anwser : anwser; ;
                }
            }

            return negative ? -anwser : anwser;
        }
    }
}
