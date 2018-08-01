using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests
{
    [TestClass()]
    public class _2_Add_Two_NumbersTests
    {
        [TestMethod()]
        public void AddTwoNumbers_V1Test()
        {
            var testData1 = new ListNode(5);
            testData1.next = new ListNode(1);

            var testData2 = new ListNode(3);
            testData2.next = new ListNode(2);

            var testClass = new _2_Add_Two_Numbers();

            testClass.AddTwoNumbers_V1(testData1, testData2);
        }
    }
}