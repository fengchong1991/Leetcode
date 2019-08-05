using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _951_Flip_Equvilant_Binary_Trees
    {
        // Running time: O(N), N is the min number of nodes in two trees
        // Space: O(H), H is the min height of two trees
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }

            if (root1 == null || root2 == null || root1.val != root2.val)
            {
                return false;
            }

            return (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right)) || (FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));

        }
    }
}
