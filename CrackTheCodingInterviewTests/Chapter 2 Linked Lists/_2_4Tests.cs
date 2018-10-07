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
    public class _2_4Tests
    {
        [TestMethod()]
        public void PartitionLinkedListTest()
        {
            var testData = new Node(5);

            testData.AppendToTail(4);
            testData.AppendToTail(65);
            testData.AppendToTail(2);
            testData.AppendToTail(34);
            testData.AppendToTail(5);
            testData.AppendToTail(4);

            var model = new _2_4();

            Console.WriteLine(model.PartitionLinkedList(testData, 1).PrintAll());
        }

        [TestMethod()]
        public void PartitionLinkedList_V2Test()
        {
            var testData = new Node(5);
            testData.AppendToTail(2);
            testData.AppendToTail(7);

            var model = new _2_4();

            Console.WriteLine(model.PartitionLinkedList_V2(testData, 4).PrintAll());
        }
    }
}