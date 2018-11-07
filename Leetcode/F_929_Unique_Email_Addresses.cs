using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //    Every email consists of a local name and a domain name, separated by the @ sign.

    //For example, in alice @leetcode.com, alice is the local name, and leetcode.com is the domain name.

    //Besides lowercase letters, these emails may contain '.'s or '+'s.

    //If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)

    //If you add a plus('+') in the local name, everything after the first plus sign will be ignored.This allows certain emails to be filtered, for example m.y+name @email.com will be forwarded to my@email.com.  (Again, this rule does not apply for domain names.)

    //It is possible to use both of these rules at the same time.

    //Given a list of emails, we send one email to each address in the list.How many different addresses actually receive mails? 




    //Example 1:

    //Input: ["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"]
    //Output: 2
    //Explanation: "testemail@leetcode.com" and "testemail@lee.tcode.com" actually receive mails
    class _929_Unique_Email_Addresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            var set = new HashSet<string>();

            foreach(var email in emails)
            {
                // Get local name
                var localIndex = email.IndexOf("@");
                var localName = email.Substring(0, localIndex);

                var plusIndex = localName.IndexOf("+");

                if(plusIndex == -1)
                {
                    set.Add(localName.Replace(".", "") + email.Substring(localIndex));
                }
                else
                {
                    set.Add(localName.Substring(0, plusIndex).Replace(".","") + email.Substring(localIndex));
                }
            }

            return set.Count;
        }
    }
}
