using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1110()
        {
            var node = new TreeNode(1);
            node.left = new TreeNode(2);

            DelNodes(node, new int[] { 2 });

        }


        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {

            var deleteSet = new HashSet<int>(to_delete);
            var result = new List<TreeNode>();

            Recurse(root, deleteSet, result, true);

            return result;
        }

        public void Recurse(TreeNode root, HashSet<int> deleteSet, List<TreeNode> result, bool isRoot = false)
        {
            if (root == null)
            {
                return;
            }

            TreeNode left = root.left;
            TreeNode right = root.right;


            if (deleteSet.Contains(root.val))
            {

                if (root.left != null)
                {
                    result.Add(root.left);
                }

                if (root.right != null)
                {
                    result.Add(root.right);
                }

                root = null;

            }
            else if (isRoot)
            {
                result.Add(root);
            }

            Recurse(left, deleteSet, result);
            Recurse(right, deleteSet, result);

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
