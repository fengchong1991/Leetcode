using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackTheCodingInterview.Chapter_2_Linked_Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_2_Linked_Lists.Tests
{
    [TestClass()]
    public class _2_6Tests
    {
        [TestMethod()]
        public void IsPalndromeTest()
        {
            var testData = new Node(5);
            testData.AppendToTail(2);
            testData.AppendToTail(4);
            testData.AppendToTail(2);
            testData.AppendToTail(5);

            var model = new _2_6();

            //Assert.AreEqual(model.IsPalndrome(null), true);
            Assert.AreEqual(model.IsPalndrome_V2(testData), true);

        }

        [TestMethod()]
        public void IsPalndromeRecurTest()
        {
            var testData = new Node(5);
            testData.AppendToTail(2);
            testData.AppendToTail(4);
            testData.AppendToTail(2);
            testData.AppendToTail(5);

            var model = new _2_6();


        }
    }
}