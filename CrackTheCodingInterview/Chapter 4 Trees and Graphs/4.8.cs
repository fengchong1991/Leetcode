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
        // If this was a binary tree, we could start from root and find where they diverge


        // If node has reference of it's parent node, we can think it as a linked list
        // Refer to question 2.7 where we find intersect of two linked list

        // Run time: O(d) depth of deeper node
        public TreeNode GetCommonAncestor_V1(TreeNode a, TreeNode b)
        {
            if(a == null || b == null)
            {
                return null;
            }

            var aDepth = GetDepth(a);
            var bDepth = GetDepth(b);

            var deeperNode = aDepth > bDepth ? a : b;
            var shallowNode = aDepth > bDepth ? b : a;
            var depthDifference = Math.Abs(aDepth - bDepth);

            while(depthDifference != 0)
            {
                deeperNode = deeperNode.Parent;
                depthDifference--;
            }

            while(deeperNode != null)
            {
                if(deeperNode == shallowNode)
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

            while(node.Parent != null)
            {
                depth++;
                node = node.Parent;
            }

            return depth;
        }


        // If node has reference to parent
        // Check subtree while going upwards
        public BinaryTreeNode GetCommonAncestor_V2(BinaryTreeNode a, BinaryTreeNode b)
        {
            if(Covers(a, b))
            {

            }

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
    }
}
