using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _107_Binary_Tree_Level_Order_Traversal_II
    {
        // Running time: O(N)
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {

            if (root == null)
            {
                return new LinkedList<IList<int>>().ToList();
            }

            // Use LinkedList
            var list = new LinkedList<IList<int>>();

            var queue = new Queue<TreeNode>();


            queue.Enqueue(root);


            while (queue.Count > 0)
            {

                var levelList = new List<int>();
                var levelSize = queue.Count;

                for (var i = 0; i < levelSize; i++)
                {

                    var node = queue.Dequeue();
                    levelList.Add(node.val);

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                list.AddFirst(levelList);
            }

            return list.ToList();
        }
    }
}
