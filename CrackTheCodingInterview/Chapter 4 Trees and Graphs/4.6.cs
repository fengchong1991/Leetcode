using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{

    //    Successor: Write an algorithm to find the "next" node(i.e., in-order successor) of a given node in a
    //binary search tree.You may assume that each node has a link to its parent.
    public class _4_6
    {
        public BinaryTreeNode FindNextNode(BinaryTreeNode node)
        {
            if(node == null)
            {
                return null;
            }

            // Traverse upward
            if (node.Right == null)
            {
                while(node.Parent != null)
                {
                    if(node.Parent.Value > node.Value)
                    {
                        return node.Parent;
                    }
                    else
                    {
                        node = node.Parent;
                    }
                }

                return null;
            }
            else
            {
                return FindLeftMost(node.Right);
            }
        }

        public BinaryTreeNode FindLeftMost(BinaryTreeNode node)
        {
            if(node == null)
            {
                return null;
            }
            
            while(node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }
    }
}
