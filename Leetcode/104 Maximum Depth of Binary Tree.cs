using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _104_Maximum_Depth_of_Binary_Tree
    {
        /// <summary>
        /// Recursive solution
        /// Space O(h), h is the height of the tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {

            if (root == null)
            {
                return 0;
            }

            var depthLeft = MaxDepth(root.left);
            var depthRight = MaxDepth(root.right);

            return Math.Max(depthLeft + 1, depthRight + 1);
        }

        /// <summary>
        /// BFS using queue
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var queue = new Queue<TreeNode>();
            var height = 0;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {

                var size = queue.Count;

                for (var i = 0; i < size; i++)
                {

                    var node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                height++;
            }

            return height;
        }
    }
}
