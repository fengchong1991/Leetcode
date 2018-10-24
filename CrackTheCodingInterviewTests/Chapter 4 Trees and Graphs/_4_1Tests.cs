using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackTheCodingInterview.Chapter_4_Trees_and_Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs.Tests
{
    [TestClass()]
    public class _4_1Tests
    {
        [TestMethod()]
        public void IsConnected_BFSTest()
        {

            var node1 = new Node() { Name = "1" };
            var node2 = new Node() { Name = "2" };
            var node3 = new Node() { Name = "3" };
            var node4 = new Node() { Name = "4" };
            var node5 = new Node() { Name = "5" };

            node1.AdjacentNodes = new List<Node> { node2 };
            node2.AdjacentNodes = new List<Node> { node1, node3, node4 };
            node4.AdjacentNodes = new List<Node> { node2 };

            var model = new _4_1();


            Assert.IsTrue(model.IsConnected_DFS(node4, node1));
        }
    }
}