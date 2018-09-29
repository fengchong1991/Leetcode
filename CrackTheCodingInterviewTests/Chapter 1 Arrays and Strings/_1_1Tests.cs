using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackTheCodingInterview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Tests
{
    [TestClass()]
    public class _1_1Tests
    {

        [TestMethod()]
        public void IsStringAllCharsUniqueTest()
        {
            var model = new _1_1();

            var testData = "fawes123";

            Assert.AreEqual(model.IsStringAllCharsUnique(testData), true);
        }

        [TestMethod()]
        public void IsStringAllCharsUnique_ArrayTest()
        {
            var model = new _1_1();

            var testData = "fawes123";

            Assert.AreEqual(model.IsStringAllCharsUnique_Array(testData), true);
        }
    }
}