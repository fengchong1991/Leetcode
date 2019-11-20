using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _437_Path_Sum_III
    {

        // Running time O(NLog(N)), if tree is balanced
        // Space O(Log(N)), if balanced
        public int PathSum(TreeNode root, int sum)
        {

            var path = new List<TreeNode>();
            return FindPath(root, path, sum);

        }

        public int FindPath(TreeNode node, List<TreeNode> pathNodes, int sum)
        {
            if (node == null)
            {
                return 0;
            }

            pathNodes.Add(node);

            var pathCount = 0;
            var pathSum = 0;

            for (var i = pathNodes.Count - 1; i >= 0; i--)
            {

                pathSum += pathNodes[i].val;

                if (pathSum == sum)
                {
                    pathCount++;
                }
            }

            pathCount += FindPath(node.left, pathNodes, sum);
            pathCount += FindPath(node.right, pathNodes, sum);

            pathNodes.RemoveAt(pathNodes.Count - 1);

            return pathCount;
        }
    }
}
