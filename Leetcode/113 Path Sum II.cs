using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{
    class _113_Path_Sum_II
    {
        // Running time O(Nlog(N))
        // Space O(Nlog(N))
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {

            var allPaths = new List<IList<int>>();
            var currentPath = new List<int>();

            Find(root, sum, currentPath, allPaths);

            return allPaths;
        }

        public void Find(TreeNode root, int sum, IList<int> currentPath, IList<IList<int>> allPaths)
        {
            if (root == null)
            {
                return;
            }

            currentPath.Add(root.val);

            if (root.left == null && root.right == null && root.val == sum)
            {
                allPaths.Add(new List<int>(currentPath));
            }
            else
            {
                Find(root.left, sum - root.val, currentPath, allPaths);
                Find(root.right, sum - root.val, currentPath, allPaths);
            }

            // Remove the current node from the path to backtrack, 
            currentPath.RemoveAt(currentPath.Count - 1);
        }
    }
}
