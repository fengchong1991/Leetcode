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
        // Run time: O(n)
        // Space complexity: O(n) data needs to be returned
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
        // Run time: O(n)
        // Space: O(n)
        public List<LinkedList<BinaryTreeNode>> CreateLinkedLists_BFS(BinaryTreeNode root)
        {
            if(root == null)
            {
                return null;
            }

            var list = new List<LinkedList<BinaryTreeNode>>();

            var linkedList = new LinkedList<BinaryTreeNode>();

            // Add the first level to the lists
            linkedList.AddLast(root);

            while(linkedList.Count > 0)
            {
                list.Add(linkedList);
                var parentList = linkedList;

                linkedList = new LinkedList<BinaryTreeNode>();

                // Add children of this level to the list
                foreach (var node in parentList)
                {
                    if (node.Left != null)
                    {
                        linkedList.AddLast(node.Left);
                    }

                    if (node.Right != null)
                    {
                        linkedList.AddLast(node.Right);
                    }
                }
            }

            return list;
        }
    }
}
