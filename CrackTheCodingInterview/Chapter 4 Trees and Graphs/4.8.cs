using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{
    //    First Common Ancestor: Design an algorithm and write code to find the first common ancestor
    //of two nodes in a binary tree.Avoid storing additional nodes in a data structure.NOTE: This is not
    //necessarily a binary search tree.
    public class _4_8
    {
        // If this was a binary search tree, we could start from root and find where they diverge


        // If node has reference of it's parent node, we can think it as a linked list
        // Refer to question 2.7 where we find intersect of two linked list
        // Run time: O(d) depth of deeper node
        public TreeNode GetCommonAncestor_V1(TreeNode a, TreeNode b)
        {
            if (a == null || b == null)
            {
                return null;
            }

            // Get depth of two nodes
            var aDepth = GetDepth(a);
            var bDepth = GetDepth(b);

            // Find and cut the extra nodes from the longer node
            var deeperNode = aDepth > bDepth ? a : b;
            var shallowNode = aDepth > bDepth ? b : a;
            var depthDifference = Math.Abs(aDepth - bDepth);

            while (depthDifference != 0)
            {
                deeperNode = deeperNode.Parent;
                depthDifference--;
            }

            // Loop through both nodes upward until we find the common node
            while (deeperNode != null)
            {
                if (deeperNode == shallowNode)
                {
                    return deeperNode;
                }

                deeperNode = deeperNode.Parent;
                shallowNode = shallowNode.Parent;
            }

            return null;
        }

        public int GetDepth(TreeNode node)
        {
            var depth = 0;

            while (node.Parent != null)
            {
                depth++;
                node = node.Parent;
            }

            return depth;
        }


        // If node has reference to parent
        // Check subtree while going upwards
        // Run time: O(t), t is the size of the subtree for the first common ancestor
        // Worst case: O(n), n is the number of nodes in this tree
        public BinaryTreeNode GetCommonAncestor_V2(BinaryTreeNode a, BinaryTreeNode b)
        {
            if (Covers(a, b))
            {
                return a;
            }
            else if (Covers(b, a))
            {
                return b;
            }

            var parent = a.Parent;
            var sibling = GetSibling(a);

            // Check if sibling contains b, if not check parent sibling
            while (!Covers(sibling, b))
            {
                sibling = GetSibling(parent);
                parent = parent.Parent;
            }

            return parent;
        }

        public bool Covers(BinaryTreeNode a, BinaryTreeNode b)
        {
            if (a == null)
            {
                return false;
            }

            if (a == b)
            {
                return true;
            }

            return Covers(a.Left, b) || Covers(a.Right, b);
        }

        public BinaryTreeNode GetSibling(BinaryTreeNode node)
        {
            if (node == null || node.Parent == null)
            {
                return null;
            }

            return node.Parent.Left == node ? node.Parent.Right : node.Parent.Left;
        }


        // If node has no reference to parent
        // Run time: (n) on a balanced tree. First two covers takes 2n, then each recursive call takes 2n/2, 2n/4...
        public BinaryTreeNode GetCommonAncestor_V3(BinaryTreeNode root, BinaryTreeNode a, BinaryTreeNode b)
        {
            // Error check
            if (!Covers(root, a) || !Covers(root, b))
            {
                return null;
            }

            return CheckNode(root, a, b);
        }

        public BinaryTreeNode CheckNode(BinaryTreeNode root, BinaryTreeNode a, BinaryTreeNode b)
        {
            // Check if a or b is at root
            if (root == a || root == b)
            {
                return root;
            }

            var atLeft = Covers(root.Left, a);
            var atRight = Covers(root.Right, b);

            // Differnt side
            if (atLeft == atRight)
            {
                return root;
            }
            // Same side
            else
            {
                var node = atLeft ? root.Left : root.Right;
                return CheckNode(node, a, b);
            }
        }

        // If node has no reference to parent
        // V3 Covers method needs to check subtree again and again 
        public BinaryTreeNode GetCommonAncestor_V4(BinaryTreeNode root, BinaryTreeNode a, BinaryTreeNode b)
        {
            if (root == null)
            {
                return null;
            }

            if (root == a && root == b)
            {
                return root;
            }

            var nodeL = GetCommonAncestor_V4(root.Left, a, b);
            var nodeR = GetCommonAncestor_V4(root.Right, a, b);
            
            // If both sides are not null, meaning two nodes appear in both sides, so root is the common ancestor
            if(nodeL != null && nodeR != null)
            {
                return root;
            }
            
            // If one side is not null
            if((nodeL != null || nodeR != null) )
            {
                // If root equals to either of the target nodes, return root
                if(root == a || root == b)
                {
                    return root;
                }
                // Return the non-null node
                else
                {
                    return nodeL ?? nodeR;
                }
            }

            // If both sides are null, return the root if it equals to either target nodes
            if(root == a || root == b)
            {
                return root;
            }
            // Return null
            else
            {
                return null;
            }
        }
    }
}
