using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _103_Binary_Tree_Zigzag_Level_Order_Traversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {

            if (root == null)
            {
                return new List<IList<int>>();
            }

            var leftToRight = false;

            var queue = new Queue<TreeNode>();

            var list = new List<IList<int>>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {

                var levelList = new List<int>();

                var levelSize = queue.Count;

                for (var i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();

                    if (leftToRight)
                    {
                        levelList.Insert(0, node.val);

                    }
                    else
                    {
                        levelList.Add(node.val);
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

                list.Add(levelList);
                leftToRight = !leftToRight;
            }

            return list;
        }

    }
}
