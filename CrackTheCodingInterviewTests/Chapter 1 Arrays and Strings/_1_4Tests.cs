using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackTheCodingInterview.Chapter_1_Arrays_and_Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_1_Arrays_and_Strings.Tests
{
    [TestClass()]
    public class _1_4Tests
    {
        [TestMethod()]
        public void IsPermutationOfPalindromeTest()
        {
            var model = new _1_4();

            Assert.AreEqual(model.IsPermutationOfPalindrome("tactcoa"), true);
        }
    }
}