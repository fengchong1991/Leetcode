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

        [TestMethod()]
        public void GetCommonAncestor_V2Test()
        {
            var model = new _4_8();

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

            Assert.AreEqual(9, model.GetCommonAncestor_V2(node4, node4).Value);

        }

        [TestMethod()]
        public void GetCommonAncestor_V3Test()
        {
            var model = new _4_8();

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

            Assert.AreEqual(8, model.GetCommonAncestor_V3(node1, node2, node6).Value);
        }
    }
}