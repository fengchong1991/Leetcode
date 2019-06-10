using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _700_Search_in_a_Binary_Search_Tree
    {
        // Running time: O(logN), N is the number of nodes if tree is balanced
        // Space O(h), h is the height of the tree
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }

            if (val < root.val)
            {
                return SearchBST(root.left, val);
            }
            else
            {
                return SearchBST(root.right, val);
            }
        }
    }
}
