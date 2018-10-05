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
    public class _2_3Tests
    {
        [TestMethod()]
        public void DeleteNodeTest()
        {
            var testData = new Node(5);
            var newNode = new Node(6);
            var newNode2 = new Node(123);
            var newNode3 = new Node(23);
            var newNode4 = new Node(51);

            testData.Next = newNode;
            newNode.Next = newNode2;
            newNode2.Next = newNode3;
            newNode3.Next = newNode4;

            var model = new _2_3();

            model.DeleteNode(newNode2);
        }
    }
}