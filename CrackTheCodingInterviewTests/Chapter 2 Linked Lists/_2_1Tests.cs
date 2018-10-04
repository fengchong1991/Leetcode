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
    public class _2_1Tests
    {
        [TestMethod()]
        public void RemoveDupsTest()
        {
            var testData = new Node(5);

            testData.AppendToTail(4);
            testData.AppendToTail(65);
            testData.AppendToTail(2);
            testData.AppendToTail(34);
            testData.AppendToTail(5);
            testData.AppendToTail(4);

            var model = new _2_1();

            model.RemoveDups(testData);
        }

        [TestMethod()]
        public void RemoveDups_V2Test()
        {
            var testData = new Node(5);

            testData.AppendToTail(4);
            testData.AppendToTail(65);
            testData.AppendToTail(2);
            testData.AppendToTail(34);
            testData.AppendToTail(5);
            testData.AppendToTail(4);

            var model = new _2_1();

            model.RemoveDups_V2(testData);
        }

        [TestMethod()]
        public void RemoveDups_NoBufferTest()
        {
            var testData = new Node(5);

            testData.AppendToTail(5);
            testData.AppendToTail(65);
            testData.AppendToTail(2);
            testData.AppendToTail(34);
            testData.AppendToTail(5);
            testData.AppendToTail(4);

            var model = new _2_1();

            model.RemoveDups_NoBuffer_V2(testData);
        }
    }
}