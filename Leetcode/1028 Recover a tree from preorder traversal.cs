using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{
    class _1028_Recover_a_tree_from_preorder_traversal
    {
        // Running time: Using Stack, O(S), S is the Length of S
        // Space: O(N), N is the depth of the tree
        public TreeNode RecoverFromPreorder(string S)
        {

            // Using Stack
            var stack = new Stack<TreeNode>();

            for (int i = 0; i < S.Length;)
            {
                var level = 0;
                var number = 0;

                while (i < S.Length && S[i] == '-')
                {
                    level++;
                    i++;
                }

                while (i < S.Length && S[i] != '-')
                {
                    number = number * 10 + int.Parse(S[i].ToString());
                    i++;
                }

                while (stack.Count > level)
                {
                    stack.Pop();
                }

                var newNode = new TreeNode(number);
                if (stack.Count == 0)
                {
                    stack.Push(newNode);
                }
                else
                {
                    var parentNode = stack.Peek();
                    if (parentNode.left == null)
                    {
                        parentNode.left = newNode;
                    }
                    else
                    {
                        parentNode.right = newNode;
                    }

                    stack.Push(newNode);
                }

            }

            while (stack.Count > 1)
            {
                stack.Pop();
            }

            return stack.Pop();
        }
    }
}
