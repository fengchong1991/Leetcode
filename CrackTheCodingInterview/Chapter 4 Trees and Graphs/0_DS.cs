using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{
    // Balanced vs. Unbalanced

    // While many trees are balanced, not all are. Ask your interviewer for clarification here. Note that balancing a
    // tree does not mean the left and right subtrees are exactly the same size(like you see under "perfect binary
    // trees" in the following diagram).

    // One way to think about it is that a "balanced" tree really means something more like "not terribly imbalanced:'
    // It's balanced enough to ensure 0( log n) times for insert and find, but it's not necessarily as
    // balanced as it could be.


    // Complete Binary Trees

    // A complete binary tree is a binary tree in which every level of the tree is fully filled, except for perhaps the
    // last level.To the extent that the last level is filled, it is filled left to right.


    // Full Binary Trees

    // A full binary tree is a binary tree in which every node has either zero or two children. That is, no nodes have
    // only one child.


    // Perfect Binary Trees
    // A perfect binary tree is one that is both full and complete. All leaf nodes will be at the same level, and this
    // level has the maximum number of nodes. A perfect tree has 2^k - 1 nodes, where k is the number of levels.

    public class TreeNode
    {
        public string Name { get; set; }
        public TreeNode[] Children { get; set; }
    }

    public class Tree
    {
        public TreeNode root { get; set; }

    }

    public class BinaryTreeNode
    {
        public BinaryTreeNode(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
                

        /// <summary>
        ///       4
        ///     /    \
        ///    2      6
        ///   / \    / \
        ///  1   3  5   7    
        /// </summary>
        /// <param name="node"></param>


        // 1 2 3 4 5 6 7
        //In-order traversal means to "visit" (often, print) the left branch, then the current node, and finally, the right branch.
        public static void InOrderTraversal(BinaryTreeNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.Left);
                // Visit(node);
                InOrderTraversal(node.Right);                
            }
        }

        // 1 3 2 5 7 6 4
        //Post-order traversal visits the current node after its child nodes(hence the name "post-order").
        public static void PostOrderTraversal(BinaryTreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                // Visit(node);
            }
        }

        // 4 2 1 3 6 5 7
        // Pre-order traversal visits the current node before its child nodes (hence the name "pre-order").
        public static void PreOrderTraversal(BinaryTreeNode node)
        {
            if (node != null)
            {
                // Visit(node);
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }
    }

    // Binary Heaps
    // A min-heap is a complete binary tree(that is, totally filled other than the rightmost elements on the last
    // level) where each node is smaller than its children.The root, therefore, is the minimum element in the tree.
    // We have two key operations on a min-heap: insert and extract_min.

    // Tries (Prefix Trees)


    // Graph

    // Adjacency List
    // This is the most common way to represent a graph.Every vertex (or node) stores a list of adjacent vertices.
    // In an undirected graph, an edge like (a, b) would be stored twice: once in a's adjacent vertices and once
    // in b's adjacent vertices.

    public class Graph
    {
        public Node[] nodes;
    }

    public class Node
    {
        public bool Visited { get; set; }
        public string Name { get; set; }
        public List<Node> AdjacentNodes { get; set; } = new List<Node>();
    }

    // Adjacency Matrices
    //    An adjacency matrix is an NxN boolean matrix(where N is the number of nodes), where a true value at
    //matrix[i][j] indicates an edge from node i to node j. (You can also use an integer matrix with Os and
    //1 s.)
       
    
    // Graph Search
    public class GraphSerach
    {
        //DFS
        public void DFSSearch(GraphNode root)
        {
            if(root == null)
            {
                return;
            }

            // Visit root
            root.Visited = true;

            foreach(var n in root.adjacent)
            {
                if (n.Visited == false)
                {
                    DFSSearch(n);
                }
            }
        }

        //BFS use queue
        public void BFSSearch(GraphNode root)
        {
            Queue<GraphNode> queue = new Queue<GraphNode>();

            root.Visited = true;

            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                var node = queue.Dequeue();
                // Visit(node);

                foreach(GraphNode n in node.adjacent)
                {
                    if(n.Visited == false)
                    {
                        n.Visited = true;
                        queue.Enqueue(n);
                    }
                }
            }
        }
                     
        public class GraphNode
        {
            public bool Visited { get; set; }
            public GraphNode[] adjacent { get; set; }
        }
    }

}
