using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _116_Populating_Next_Right_Pointers_in_Each_Node
    {
        public Node Connect(Node root)
        {

            if (root == null)
            {
                return root;
            }

            var queue = new Queue<Node>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {

                var levelSize = queue.Count;

                Node prevNode = null;

                for (var i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();

                    if (prevNode != null)
                    {
                        prevNode.next = node;
                    }

                    prevNode = node;

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

            return root;
        }
    }
}
