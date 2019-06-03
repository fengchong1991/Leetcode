/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// Time complexity: O(N) 
// Space complexity: O(H), h is the height of the tree
public class Solution
{
    public int RangeSumBST(TreeNode root, int L, int R)
    {

        if (root == null)
        {
            return 0;
        }

        int sum = 0;
        if (root.val > L)
        {
            sum += RangeSumBST(root.left, L, R);
        }

        if (root.val >= L && root.val <= R)
        {
            sum += root.val;
        }

        if (root.val < R)
        {
            sum += RangeSumBST(root.right, L, R);
        }

        return sum;
    }
}