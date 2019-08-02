using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _559_Maximum_Depth_of_N_ary_Tree
    {
        // Running time: O(N), N is the number of nodes
        public int MaxDepth(Node root)
        {

            if (root == null)
            {
                return 0;
            }

            var max = 0;
            foreach (var child in root.children)
            {
                max = Math.Max(max, MaxDepth(child));
            }

            return max + 1;
        }


        // Use BFS with queue
        // Running time O(N)
        public int MaxDepth_V2(Node root)
        {

            if (root == null)
            {
                return 0;
            }

            var queue = new Queue<Node>();
            var depth = 0;

            queue.Enqueue(root);

            while (queue.Count != 0)
            {

                var queueCount = queue.Count;

                for (var i = 0; i < queueCount; i++)
                {
                    var n = queue.Dequeue();
                    foreach (var node in n.children)
                    {
                        queue.Enqueue(node);
                    }
                }

                depth++;
            }

            return depth;
        }
    }
}
