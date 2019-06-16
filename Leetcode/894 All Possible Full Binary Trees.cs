using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{
    class _894_All_Possible_Full_Binary_Trees
    {
        public IList<TreeNode> AllPossibleFBT(int N)
        {

            var result = new List<TreeNode>();

            if (N % 2 == 0)
            {
                return result;
            }

            if (N == 1)
            {
                result.Add(new TreeNode(0));
                return result;
            }

            for (var i = 1; i < N; i += 2)
            {
                var left = AllPossibleFBT(i);
                var right = AllPossibleFBT(N - 1 - i);

                foreach (var lNode in left)
                {
                    foreach (var rNode in right)
                    {
                        var currentNode = new TreeNode(0);

                        currentNode.left = lNode;
                        currentNode.right = rNode;
                        result.Add(currentNode);
                    }
                }
            }

            return result;
        }

    }
}
