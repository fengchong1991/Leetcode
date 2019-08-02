using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _979_Distribute_Coins_in_Binary_Tree
    {
        // Running time: O(N), N is number of nodes
        // Space: O(H), H is the height of the tree

        private int moves;

        public int DistributeCoins(TreeNode root)
        {
            Math.Abs(GetMoves(root));
            return moves;
        }

        public int GetMoves(TreeNode root)
        {

            if (root == null)
            {
                return 0;
            }

            var leftMove = GetMoves(root.left);
            var rightMove = GetMoves(root.right);

            moves += Math.Abs(leftMove) + Math.Abs(rightMove);
            return root.val - 1 + leftMove + rightMove;
        }
    }
}
