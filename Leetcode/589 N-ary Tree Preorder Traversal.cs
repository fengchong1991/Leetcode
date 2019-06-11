using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _589_N_ary_Tree_Preorder_Traversal
    {
        public IList<int> Preorder(Node root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            var stack = new Stack<Node>();

            stack.Push(root);

            while (stack.Count > 0)
            {

                var node = stack.Pop();

                result.Add(node.val);

                for (var i = node.children.Count - 1; i >= 0; i--)
                {
                    stack.Push(node.children[i]);
                }

            }

            return result;
        }
    }
}
