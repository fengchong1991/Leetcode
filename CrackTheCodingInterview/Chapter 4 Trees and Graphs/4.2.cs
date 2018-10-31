using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{

    //    Minimal Tree: Given a sorted(increasing order) array with unique integer elements, write an
    //algorithm to create a binary search tree with minimal height.
    public class _4_2
    {
        public BinaryTreeNode CreateBinaryTree(int[] array)
        {
            return ConstructTree(0, array.Length - 1, array);
        }

        private BinaryTreeNode ConstructTree(int startIndex, int endIndex, int[] array)
        {
            if(startIndex > endIndex)
            {
                return null;
            }

            // Mid is sum of (start and end)/2
            var mid = (endIndex + startIndex) / 2;

            var node = new BinaryTreeNode(array[mid]);

            node.Left = ConstructTree(startIndex, mid-1, array);
            node.Right = ConstructTree(mid + 1, endIndex, array);

            return node;
        }
    }
}
