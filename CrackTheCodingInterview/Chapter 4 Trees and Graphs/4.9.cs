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
        //public List<List<int>> PrintAllCombination(BinaryTreeNode node)
        //{
        //    List<List<int>> combinations = new List<List<int>>();

        //    if(node == null)
        //    {
        //        combinations.Add(new List<int>());
        //    }

        //    List<List<int>> leftSeqs = PrintAllCombination(node.Left);
        //    List<List<int>> rightSeqs = PrintAllCombination(node.Right);

        //    foreach (var leftSeq in leftSeqs)
        //    {
        //        foreach(var rightSeq in rightSeqs)
        //        {
        //            var result = new List<List<int>>();
        //            combinations.AddRange(WeaveList(leftSeq, rightSeq, result));
        //        }
        //    }
            
        //    return combinations;
        //}

        //public List<List<int>> WeaveList(List<int> first, List<int> right, List<List<int>>result)
        //{
            

        //}

        public static List<List<int>> AllSequesnces(BinaryTreeNode node)
        {
            if(node == null)
            {
                throw new Exception();
            }

            var nodeList = new List<BinaryTreeNode>() { node };

            return AllSequesnces(nodeList);
        }

        public static List<List<int>> AllSequesnces(List<BinaryTreeNode> nodes)
        {

            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];

                var nodesCopy = new List<BinaryTreeNode>();

                nodes.ForEach(n => nodesCopy.Add(n));
               
                // Remove the first node, push its children to the nodes list
                nodesCopy.RemoveAt(i);
                
                if(node.Left != null)
                {
                    nodesCopy.Add(node.Left);
                }
                
                if(node.Right != null)
                {
                    nodesCopy.Add(node.Right);
                }
                
                if(nodesCopy.Count > 0)
                {
                    foreach (var s in AllSequesnces(nodesCopy))
                    {
                        s.Insert(0, node.Value);
                        result.Add(s);
                    }
                }
                else
                {
                    result.Add(new List<int> { node.Value });
                }
            }

            return result;
        }
    }
}
