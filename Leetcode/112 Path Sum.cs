﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _112_Path_Sum
    {
        // Running time O(N)
        // Space O(log(N))
        public bool HasPathSum(TreeNode root, int sum)
        {

            if (root == null)
            {
                return false;
            }

            if (root.left == null && root.right == null)
            {
                return root.val == sum;
            }


            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
    }
}
