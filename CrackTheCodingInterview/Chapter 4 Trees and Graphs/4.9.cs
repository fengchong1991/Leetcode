using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{
    //    BST Sequences: A binary search tree was created by traversing through an array from left to right
    //and inserting each element.Given a binary search tree with distinct elements, print all possible
    //arrays that could have led to this tree.

    public class _4_9
    {
        public List<LinkedList<BinaryTreeNode>> PrintAllCombination(BinaryTreeNode node)
        {
            List<LinkedList<BinaryTreeNode>> combinations = new List<LinkedList<BinaryTreeNode>>();

            if(node == null)
            {
                combinations.Add(new LinkedList<BinaryTreeNode>());
            }


            return combinations;
        }

        public void AddNode(List<BinaryTreeNode> list, BinaryTreeNode node)
        {
            
        }
    }
}
