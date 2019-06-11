using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _965_Univalued_Binary_Tree
    {
        // Running time: O(N), N is number of nodes
        // Space: O(H), H is the height
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (root.left != null && root.val != root.left.val)
            {
                return false;
            }

            if (root.right != null && root.val != root.right.val)
            {
                return false;
            }

            return IsUnivalTree(root.left) && IsUnivalTree(root.right);
        }
    }
}
