using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1110()
        {

            ConstructFromPrePost(new int[] {2,1 }, new int[] {1,2 });
        }

        public TreeNode ConstructFromPrePost(int[] pre, int[] post)
        {
            if (pre.Length == 0)
            {
                return null;
            }

            var root = new TreeNode(pre[0]);

            if (pre.Length == 1)
            {
                return root;
            }

            for (var j = 0; j < post.Length; j++)
            {
                if (pre[1] == post[j])
                {
                    root.left = ConstructFromPrePost(pre.Skip(1).Take(j + 1).ToArray(), post.Take(j + 1).ToArray());
                    root.right = ConstructFromPrePost(pre.Skip(j + 2).ToArray(), post.Skip(j + 1).ToArray());
                    break;
                }
            }

            return root;
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
