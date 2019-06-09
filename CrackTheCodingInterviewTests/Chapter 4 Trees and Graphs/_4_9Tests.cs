using System;
using System.Collections.Generic;
using CrackTheCodingInterview.Chapter_4_Trees_and_Graphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackTheCodingInterviewTests.Chapter_4_Trees_and_Graphs
{
    [TestClass]
    public class _4_9Tests
    {
        [TestMethod]
        public void AllSequences_Test()
        {
            var root = new BinaryTreeNode(10);

            var n1 = new BinaryTreeNode(3);

            var n2 = new BinaryTreeNode(12);
            var n3 = new BinaryTreeNode(7);
            var n4 = new BinaryTreeNode(1);

            root.Left = n1;
            root.Right = n2;
            n1.Right = n3;
            n1.Left = n4;

            var result = _4_9.AllSequesnces(root);

            System.Diagnostics.Debug.WriteLine(result);

        }
    }
}
