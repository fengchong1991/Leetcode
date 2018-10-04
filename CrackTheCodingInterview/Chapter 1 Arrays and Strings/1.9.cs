using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_1_Arrays_and_Strings
{
	//    String Rotation: Assume you have a method i 5Su b 5 tr ing which checks if one word is a substring
	//of another.Given two strings, 51 and 52, write code to check if 52 is a rotation of 51 using only one
	//call to i5Sub5tring(e.g., "waterbottle" is a rotation of" erbottlewat").
    public class _1_9
    {
		public bool IsRotation(string s1, string s2)
        {
			if(s1.Length == s2.Length && s1.Length > 0)
            {
                var s1s1 = s1 + s1;

                //return isSubString(s1s1, s2);
                return true;
            }

            return false;
        }		
    }
}
