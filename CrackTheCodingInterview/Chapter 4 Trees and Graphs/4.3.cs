using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackTheCodingInterview.Chapter_2_Linked_Lists;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{

    //    List of Depths: Given a binary tree, design an algorithm which creates a linked list of all the nodes
    //at each depth(e.g., if you have a tree with depth D, you'll have D linked lists).

    public class _4_3
    {
        // Use pre-order tranversal to do this
        public List<LinkedList<BinaryTreeNode>> CreateLinkedLists(BinaryTreeNode root) 
        {

            var listOfLinkedList = new List<LinkedList<BinaryTreeNode>>();

            CreateLinkedList(root, listOfLinkedList, 0);

            return listOfLinkedList;
        }   
        
        private void CreateLinkedList(BinaryTreeNode node, List<LinkedList<BinaryTreeNode>> listOfLinkedList, int level)
        {
            if(node == null)
            {
                return;
            }

            if(listOfLinkedList.Count == level)
            {
                listOfLinkedList.Add(new LinkedList<BinaryTreeNode>());
            }

            listOfLinkedList[level].AddLast(new BinaryTreeNode(node.Value));
            CreateLinkedList(node.Left, listOfLinkedList, level + 1);
            CreateLinkedList(node.Right, listOfLinkedList, level + 1);            
        }


        // Use breadth-first traversal 
        public List<LinkedList<BinaryTreeNode>> CreateLinkedLists_BFS(BinaryTreeNode node)
        {

        }
    }
}
