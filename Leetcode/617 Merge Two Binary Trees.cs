using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _617_Merge_Two_Binary_Trees
    {
        // Running time: O(N), N is the number of nodes in the smaller tree
        // Space: O(N), if tree is not balanced, or O(logN) if balanced
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
            {
                return t2;
            }

            if (t2 == null)
            {
                return t1;
            }

            t1.val += t2.val;

            t1.left = MergeTrees(t1.left, t2.left);
            t1.right = MergeTrees(t1.right, t2.right);

            return t1;
        }
    }
}
