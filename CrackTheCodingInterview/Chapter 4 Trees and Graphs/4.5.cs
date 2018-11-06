using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{
    // Validate BST: Implement a function to check if a binary tree is a binary search tree.
    public class _4_5
    {
        // A binary tree can have duplicates, duplicate must be at left branch
        // Assume the tree doesn't contain duplicates, traverse it with in-order traversal
        public bool IsBinaryTree(BinaryTreeNode node)
        {
            var list = new List<int>();
            Traversal(node, list);

            for (var i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public void Traversal(BinaryTreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            Traversal(node.Left, list);
            list.Add(node.Value);
            Traversal(node.Right, list);
        }

        // We don't really need to have that list to save all nodes, just compare them as it goes
        private BinaryTreeNode lastNode;

        public bool IsBinaryTree_V2(BinaryTreeNode node)
        {
            if(node == null)
            {
                return true;
            }

            if (!IsBinaryTree_V2(node.Left))
            {
                return false;
            }

            // Compare this node with last node
            if(lastNode != null && lastNode.Value > node.Value)
            {
                return false;
            }
            lastNode = node;

            if (!IsBinaryTree_V2(node.Right))
            {
                return false;
            }

            return true;
        }

        // Pass min and max from top to bottom, update min if branch right, update max if branch left
        public bool IsBinaryTree_V3(BinaryTreeNode node, int? min = null, int? max = null)
        {
            if(node == null)
            {
                return true;
            }

            if((min != null && node.Value < min) || (max != null && node.Value >= max))
            {
                return false;
            }

            return IsBinaryTree_V3(node.Left, min, node.Value) && IsBinaryTree_V3(node.Right, node.Value, max);
        }
    }
}
