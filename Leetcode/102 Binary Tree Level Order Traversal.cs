﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _102_Binary_Tree_Level_Order_Traversal
    {

        // Running time: O(N), n is the number of nodes
        // Space: O(N)
        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            if (root == null)
            {
                return new List<IList<int>>();
            }

            var list = new List<IList<int>>();

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

                list.Add(levelList);
            }

            return list;
        }
    }
}
