using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _701_Insert_into_a_Binary_Search_Tree
    {
        // Running time: O(LogN), if tree is balanced
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val);
            }

            if (val > root.val)
            {
                root.right = InsertIntoBST(root.right, val);
            }

            if (val < root.val)
            {
                root.left = InsertIntoBST(root.left, val);
            }

            return root;
        }
    }
}
