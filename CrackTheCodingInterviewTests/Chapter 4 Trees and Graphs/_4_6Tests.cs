﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackTheCodingInterview.Chapter_4_Trees_and_Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs.Tests
{
    [TestClass()]
    public class _4_6Tests
    {
        [TestMethod()]
        public void FindNextNodeTest()
        {
            var model = new _4_6();

            var node1 = new BinaryTreeNode(12);
            var node2 = new BinaryTreeNode(8);
            var node3 = new BinaryTreeNode(2);
            var node4 = new BinaryTreeNode(9);
            var node5 = new BinaryTreeNode(15);
            var node6 = new BinaryTreeNode(11);

            node1.Left = node2;
            node1.Right = node5;
            node2.Left = node3;
            node2.Right = node4;
            node4.Right = node6;

            node2.Parent = node1;
            node5.Parent = node1;
            node3.Parent = node2;
            node4.Parent = node2;
            node6.Parent = node4;

            Assert.AreEqual(8, model.FindNextNode(node3).Value);
        }
    }
}