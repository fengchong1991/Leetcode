using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_1_Arrays_and_Strings
{

    //    One Away: There are three types of edits that can be performed on strings: insert a character,
    //remove a character, or replace a character.Given two strings, write a function to check if they are
    //one edit (or zero edits) away.
    //EXAMPLE
    //pale, ple -> true
    //pales, pale -> true
    //pale, bale -> true
    //pale, bae -> false
    public class _1_5
    {
        public bool OneOrZeroAway(string a, string b)
        {
            if(a.Length == b.Length)
            {
                var difference = false;

                for(var i = 0; i< a.Length; i++)
                {
                    if(a[i] != b[i])
                    {
                        if(difference)
                        {
                            return false;
                        }

                        difference = true;
                    }
                }

                return true;
            }
            else if (a.Length + 1 == b.Length)
            {
                for(var i = 0; i< a.Length; i++)
                {
                    if(a[i] != b[i] && a.Substring(i) == b.Substring(i+1))
                    {
                        return true;
                    }
                }

                return false;
            }
            else if (a.Length - 1 == b.Length)
            {
                for (var i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i] && a.Substring(i+1) == b.Substring(i))
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
