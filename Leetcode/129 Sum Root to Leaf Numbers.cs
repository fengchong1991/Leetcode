using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _129_Sum_Root_to_Leaf_Numbers
    {
        int totalSum = 0;
        public int SumNumbers(TreeNode root)
        {

            Sum(root, 0);

            return totalSum;

        }

        public void Sum(TreeNode node, int sum)
        {
            if (node == null)
            {
                return;
            }

            if (node.left == null && node.right == null)
            {
                sum += node.val;
                totalSum += sum;
            }
            else
            {
                Sum(node.left, (sum + node.val) * 10);
                Sum(node.right, (sum + node.val) * 10);
            }
        }

        // No external variable solution
        public int SumNumbers(TreeNode root)
        {
            return Sum(root, 0);
        }

        public int Sum(TreeNode node, int sum)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.left == null && node.right == null)
            {
                return sum += node.val;
            }

            return Sum(node.left, (sum + node.val) * 10) + Sum(node.right, (sum + node.val) * 10);
        }

    }
}
