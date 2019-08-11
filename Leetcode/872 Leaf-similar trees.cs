using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _872_Leaf_similar_trees
    {
        // Running time O(M+N), M is the size of tree1, N is the size of tree 2
        // Space: O(M+N)
        // Use DFS to get sequence
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {

            var sequence1 = new List<int>();
            GetSequence(root1, sequence1);

            var sequence2 = new List<int>();
            GetSequence(root2, sequence2);

            return sequence1.SequenceEqual(sequence2);
        }

        public void GetSequence(TreeNode root, List<int> sequence)
        {
            if (root == null)
            {
                return;
            }

            GetSequence(root.left, sequence);

            if (root.left == null && root.right == null)
            {
                sequence.Add(root.val);
            }

            GetSequence(root.right, sequence);
        }

        // Use a stack and compare each leaf at a time
        // Running time: O(M+N)
        // Space: O(H1+H2)
        public bool LeafSimilar_V2(TreeNode root1, TreeNode root2)
        {
            var stack1 = new Stack<TreeNode>();
            var stack2 = new Stack<TreeNode>();

            stack1.Push(root1);
            stack2.Push(root2);

            while (stack1.Count > 0 && stack2.Count > 0)
            {
                if (GetSequence_V2(stack1) != GetSequence_V2(stack2))
                {
                    return false;
                }
            }

            return stack1.Count == 0 && stack2.Count == 0;
        }

        public int GetSequence_V2(Stack<TreeNode> stack)
        {
            while (true)
            {
                var node = stack.Pop();

                if (node.right != null)
                {
                    stack.Push(node.right);
                }

                if (node.left != null)
                {
                    stack.Push(node.left);
                }

                if (node.left == null && node.right == null)
                {
                    return node.val;
                }
            }
        }
    }
}
