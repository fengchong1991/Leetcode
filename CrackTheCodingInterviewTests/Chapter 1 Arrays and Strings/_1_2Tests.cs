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
    public class _1_2Tests
    {
        [TestMethod()]
        public void IsPermutationTest()
        {
            var model = new _1_2();

            Assert.AreEqual(model.IsPermutation("dog", "god"), true);
        }

        [TestMethod()]
        public void IsPermutation_V2Test()
        {
            var model = new _1_2();

            Assert.AreEqual(model.IsPermutation_V2("dog", "god"), true);
        }
    }
}