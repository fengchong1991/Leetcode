using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_979()
        {
            var node = new TreeNode(3);
            node.left = new TreeNode(0);
            node.right = new TreeNode(0);

            var model = new _979_Distribute_Coins_in_Binary_Tree();

            Assert.AreEqual(2, model.DistributeCoins(node));
        }

    }

    public class _979_Distribute_Coins_in_Binary_Tree
    {
        public int DistributeCoins(TreeNode root)
        {


            return GetMoves(root) - Math.Abs(root.val - 1);
        }

        public int GetMoves(TreeNode root)
        {

            if (root == null)
            {
                return 0;
            }

            var total = 0;

            var leftMove = DistributeCoins(root.left);
            var rightMove = DistributeCoins(root.right);

            total = leftMove + rightMove;

            if (root.val != 1)
            {
                total += Math.Abs(root.val - 1);
            }

            return total;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
