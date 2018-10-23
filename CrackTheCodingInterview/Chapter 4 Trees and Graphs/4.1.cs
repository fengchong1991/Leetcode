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

            
                     

            return false;
        }


        public bool IsConnected_BFS(Node start, Node end)
        {
            if(start == end)
            {
                return true;
            }

            return false;
        }
        


        public class Node
        {
            public bool Visited { get; set; }
            Node[] AdjacentNodes { get; set; }
        }
    }
}
