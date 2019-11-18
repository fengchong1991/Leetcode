using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _111_Minimum_depth_of_binary_tree
    {

        public int MinDepth(TreeNode root)
        {

            if (root == null)
            {
                return 0;
            }

            var level = 0;

            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                level++;

                var levelSize = queue.Count;

                for (var i = 0; i < levelSize; i++)
                {

                    var node = queue.Dequeue();

                    if (node.left == null && node.right == null)
                    {
                        return level;
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }

            return level;
        }
    }
}
