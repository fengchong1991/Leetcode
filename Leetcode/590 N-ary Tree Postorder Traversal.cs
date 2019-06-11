using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _590_N_ary_Tree_Postorder_Traversal
    {
        /*
            // Definition for a Node.
            public class Node {
                public int val;
                public IList<Node> children;

                public Node(){}
                public Node(int _val,IList<Node> _children) {
                    val = _val;
                    children = _children;
            }
        */

        // Using a stack
        // Running time: O(N)
        // Space: O(N)
        public IList<int> Postorder(Node root)
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

                foreach (var childNode in node.children)
                {
                    stack.Push(childNode);
                }
            }

            result.Reverse();

            return result;
        }

        public IList<int> Postorder(Node root)
        {

            var result = new List<int>();
            if (root == null)
            {
                return result;
            }

            Traverse(root, result);
            return result;
        }

        public void Traverse(Node root, List<int> result)
        {
            foreach (var child in root.children)
            {
                Traverse(child, result);
            }

            result.Add(root.val);
        }
    }
}
