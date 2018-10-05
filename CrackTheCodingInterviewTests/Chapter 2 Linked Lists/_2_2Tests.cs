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
    public class _2_2Tests
    {
        [TestMethod()]
        public void FindKthToLastTest()
        {
            var testData = new Node(5);

            testData.AppendToTail(4);
            testData.AppendToTail(65);
            testData.AppendToTail(2);
            testData.AppendToTail(34);
            testData.AppendToTail(5);
            testData.AppendToTail(4);

            var model = new _2_2();

            Assert.AreEqual(model.FindKthToLast(testData, 5).Data, 65);
            Assert.AreEqual(model.FindKthToLast(testData, 5).Data, 65);
            Assert.AreEqual(model.FindKthToLast(testData, 1).Data, 4);
        }
    }
}