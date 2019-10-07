using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _889_Construct_Binary_Tree_from_Preorder_and_Postorder_Traversal
    {
        /// <summary>
        /// Running time O(N^2)
        /// </summary>
        /// <param name="pre"></param>
        /// <param name="post"></param>
        /// <returns></returns>
        public TreeNode ConstructFromPrePost(int[] pre, int[] post)
        {
            if (pre.Length == 0)
            {
                return null;
            }

            var root = new TreeNode(pre[0]);

            if (pre.Length == 1)
            {
                return root;
            }

            for (var j = 0; j < post.Length; j++)
            {
                if (pre[1] == post[j])
                {
                    // Find the left subtree
                    root.left = ConstructFromPrePost(pre.Skip(1).Take(j + 1).ToArray(), post.Take(j + 1).ToArray());

                    // Find the right subtree
                    root.right = ConstructFromPrePost(pre.Skip(j + 2).ToArray(), post.Skip(j + 1).ToArray());
                    break;
                }
            }

            return root;
        }

        /// <summary>
        /// If post value equals node value, that means whole sub tree is constructed  
        /// Running time O(N)
        /// </summary>
        int preIndex = 0;
        int postIndex = 0;
        public TreeNode ConstructFromPrePost_V2(int[] pre, int[] post)
        {
            var node = new TreeNode(pre[preIndex++]);

            if (node.val != post[postIndex])
            {
                node.left = ConstructFromPrePost_V2(pre, post);
            }

            if (node.val != post[postIndex])
            {
                node.right = ConstructFromPrePost_V2(pre, post);
            }

            postIndex++;
            return node;
        }
    }
}
