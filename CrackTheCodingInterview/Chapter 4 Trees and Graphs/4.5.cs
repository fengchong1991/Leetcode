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
        // If the tree doesn't contain duplicates, traverse it with in-order traversal
        public bool IsBinaryTree(BinaryTreeNode node)
        {
            var list = new List<int>();
            Traversal(node, list);
            
            foreach(var i in list)
            {
                
            }
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
    }
}
