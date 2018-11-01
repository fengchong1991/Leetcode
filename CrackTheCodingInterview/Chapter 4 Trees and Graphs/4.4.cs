using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{
    //    Check Balanced: Implement a function to check if a binary tree is balanced.For the purposes of
    //this question, a balanced tree is defined to be a tree such that the heights of the two subtrees of any
    //node never differ by more than one.
    public class _4_4
    {
        // Recursively 
        // Run time: O(n)
        // Space O(h) h for height
        public Result IsBalanced(BinaryTreeNode node)
        {
            if (node == null)
            {
                return new Result()
                {
                    Height = 0,
                    Balanced = true
                };
            }

            if(node.Left == null && node.Right == null)
            {
                return new Result
                {
                    Height = 1,
                    Balanced = true
                };
            }

            var resultL = IsBalanced(node.Left);
            var resultR = IsBalanced(node.Right);

            if(!resultL.Balanced || !resultR.Balanced)
            {
                return new Result
                {
                    Balanced = false
                };
            }

            var heightDifference = resultL.Height - resultR.Height;
            if (Math.Abs(heightDifference) > 1)
            {
                return new Result
                {
                    Balanced = false
                };
            }


            return new Result
            {
                Height = Math.Max(resultL.Height, resultR.Height)+1,
                Balanced = true
            };
        }

        public class Result
        {
            public int Height { get; set; }
            public bool Balanced { get; set; }
        }


        // Calculate height at each node, not efficient
        // Run time: O(nlogn)
        public bool IsBalanced_V2(BinaryTreeNode root)
        {
            if(root == null)
            {
                return true;
            }

            var difference = GetHeight(root.Left) - GetHeight(root.Right);

            if (Math.Abs(difference) > 1)
            {
                return false;
            }
            else
            {
                return IsBalanced_V2(root.Left) && IsBalanced_V2(root.Right);
            }
        }

        public int GetHeight(BinaryTreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            var heightL = GetHeight(node.Left);
            var heightR = GetHeight(node.Right);

            return Math.Max(heightL, heightR) + 1;
        }

    }
}
