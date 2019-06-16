using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _1008_Construct_Binary_Search_Tree_from_Preorder_Traversal
    {
        // Running time: O(NLogN)
        public TreeNode BstFromPreorder(int[] preorder)
        {

            if (preorder == null || preorder.Length == 0)
            {
                return null;
            }

            return BstFromPreorder(preorder, 0, preorder.Length - 1);
        }

        public TreeNode BstFromPreorder(int[] preorder, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var currentNode = new TreeNode(preorder[start]);

            var lastIndex = start;
            for (var i = start; i <= end; i++)
            {
                if (preorder[i] > preorder[start])
                {
                    break;
                }

                lastIndex = i;
            }

            currentNode.left = BstFromPreorder(preorder, start + 1, lastIndex);
            currentNode.right = BstFromPreorder(preorder, lastIndex + 1, end);

            return currentNode;
        }

        // Running time: O(N)
        // Pass the bound down the tree, keep a global index to track the current index.
        // If the value at index i is smaller than the bound, create a node. Otherwise, return null and exam the right subtree.
        int i = 0;

        public TreeNode BstFromPreorder_V2(int[] preorder)
        {
            return BstFromPreorder_V2(preorder, int.MaxValue);
        }

        public TreeNode BstFromPreorder_V2(int[] preorder, int bound)
        {
            if (i == preorder.Length || preorder[i] > bound)
            {
                return null;
            }


            var node = new TreeNode(preorder[i++]);

            node.left = BstFromPreorder_V2(preorder, node.val);
            node.right = BstFromPreorder_V2(preorder, bound);

            return node;
        }
    }
}
