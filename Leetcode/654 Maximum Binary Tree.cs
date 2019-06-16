using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _654_Maximum_Binary_Tree
    {
        // Running time: O(NLogN), LogN is the depth of the tree if balanced
        // Space: O(LogN)
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {

            return Construct(nums, 0, nums.Length);
        }

        public TreeNode Construct(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return null;
            }

            var max = nums[left];
            var maxIndex = left;
            for (int i = left; i < right; i++)
            {
                if (nums[i] > max)
                {
                    maxIndex = i;
                    max = nums[i];
                }
            }

            var node = new TreeNode(nums[maxIndex]);

            node.left = Construct(nums, left, maxIndex);
            node.right = Construct(nums, maxIndex + 1, right);

            return node;
        }
    }
}
