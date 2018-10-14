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
    public class _2_8Tests
    {
        [TestMethod()]
        public void FindLoopTest()
        {
            var testData = new Node(5);
            var t1 = new Node(3);
            var t2 = new Node(1);
            var t3 = new Node(4);
            var t4 = new Node(7);

            testData.Next = t1;
            t1.Next = t2;
            t2.Next = t3;
            t3.Next = t4;
            t4.Next = testData;

            var model = new _2_8();


            Assert.AreEqual(model.FindLoop(testData).Data, 5);
        }
    }
}