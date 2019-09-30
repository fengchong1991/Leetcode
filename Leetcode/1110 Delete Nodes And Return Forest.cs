using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _1110_Delete_Nodes_And_Return_Forest
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            TreeNode(int x) { val = x; }
        }

        /// <summary>
        /// Running time O(N)
        /// Space O(N)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="to_delete"></param>
        /// <returns></returns>
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {

            var deleteSet = new HashSet<int>(to_delete);
            var result = new List<TreeNode>();
            if (!deleteSet.Contains(root.val)) result.Add(root);

            Recurse(root, deleteSet, result);

            return result;
        }

        public TreeNode Recurse(TreeNode root, HashSet<int> deleteSet, List<TreeNode> result)
        {
            if (root == null)
            {
                return null;
            }

            root.left = Recurse(root.left, deleteSet, result);
            root.right = Recurse(root.right, deleteSet, result);

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

                return null;
            }

            return root;
        }

    }
}
