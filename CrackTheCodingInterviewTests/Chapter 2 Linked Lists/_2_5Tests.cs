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
    public class _2_5Tests
    {
        [TestMethod()]
        public void SumTest()
        {
            var testData = new Node(5);
            testData.AppendToTail(2);
            testData.AppendToTail(1);

            var testData2 = new Node(0);

            var model = new _2_5();
            Console.WriteLine(model.Sum(testData, testData2));
        }
    }
}