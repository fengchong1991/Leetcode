using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _1026_Maximum_Difference_Between_Node_and_Ancestor
    {

        /// <summary>
        /// Running time: O(N), N is the number of nodes
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxAncestorDiff(TreeNode root)
        {
            return DFS(root, root.val, root.val);

        }

        public int DFS(TreeNode node, int min, int max)
        {

            if (node == null)
            {
                return max - min;
            }

            min = Math.Min(min, node.val);
            max = Math.Max(max, node.val);

            var left = DFS(node.left, min, max);
            var right = DFS(node.right, min, max);

            return Math.Max(left, right);
        }
    }
}
