using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{
    //    Route Between Nodes: Given a directed graph, design an algorithm to find out whether there is a
    //route between two nodes.
    public class _4_1
    {

        public bool IsConnected_DFS(Node start, Node end)
        {
            if(start == end)
            {
                return true;
            }

            start.Visited = true;

            foreach (var node in start.AdjacentNodes)
            {
                if (node.Visited == false)
                {
                    var result = IsConnected_DFS(node, end);

                    if(result == true)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsConnected_BFS(Node start, Node end)
        {
            if(start == null || end == null)
            {
                return false;
            }

            if(start == end)
            {
                return true;
            }

            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(start);

            while(queue.Count != 0)
            {
                var node = queue.Dequeue();

                foreach(var n in node.AdjacentNodes)
                {
                    if(n.Visited == false)
                    {
                        if (n == end)
                        {
                            return true;
                        }
                        else
                        {
                            n.Visited = true;
                            queue.Enqueue(n);
                        }
                    }
                }
            }
            
            return false;
        }
    }
}
