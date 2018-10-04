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
    public class _1_6Tests
    {
        [TestMethod()]
        public void CompressStringTest()
        {
            var model = new _1_6();

            Assert.AreEqual(model.CompressString("aabcccccaaa"), "a2b1c5a3");
        }

        [TestMethod()]
        public void CompressString_V2Test()
        {
            var model = new _1_6();

            Assert.AreEqual(model.CompressString("aabcccccaaa"), "a2b1c5a3");
        }
    }
}