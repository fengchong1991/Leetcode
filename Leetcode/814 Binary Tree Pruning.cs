using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /**
    * Definition for a binary tree node.
    * public class TreeNode {
    *     public int val;
    *     public TreeNode left;
    *     public TreeNode right;
    *     public TreeNode(int x) { val = x; }
    * }
    */
    class _814_Binary_Tree_Pruning
    {
        // Running time: O(N), we process each node once
        // Space: O(H), H is the height
        public TreeNode PruneTree(TreeNode root)
        {

            if (root == null)
            {
                return null;
            }

            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);

            if (root.left == null && root.right == null && root.val == 0)
            {
                return null;
            }

            return root;
        }
    }
}
