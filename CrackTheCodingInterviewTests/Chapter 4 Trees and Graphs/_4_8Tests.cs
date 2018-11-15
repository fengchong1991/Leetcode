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
    public class _4_8Tests
    {
        [TestMethod()]
        public void GetCommonAncestor_V1Test()
        {
            var model = new _4_8();

            var node1 = new TreeNode(12);
            var node2 = new TreeNode(8);
            var node3 = new TreeNode(2);
            var node4 = new TreeNode(9);
            var node5 = new TreeNode(15);
            var node6 = new TreeNode(11);

            node2.Parent = node1;
            node5.Parent = node1;
            node3.Parent = node2;
            node4.Parent = node2;
            node6.Parent = node4;

            Assert.AreEqual(9, model.GetCommonAncestor_V1(node6, node4).Data);
        }
    }
}