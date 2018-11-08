using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs
{
    //    Build Order: You are given a list of projects and a list of dependencies(which is a list of pairs of
    //projects, where the second project is dependent on the first project). All of a project's dependencies
    //must be built before the project is. Find a build order that will allow the projects to be built.If there
    //is no valid build order, return an error.
    //EXAMPLE
    //Input:
    //projects: a, b, c, d, e, f
    //dependencies: (a, d), (f, b), (b, d), (f, a), (d, c)
    //Output: f, e, a, b, d, c
    public class _4_7
    {

        public void CreateBuildOrder(Project[] projects)
        {
            
            // Find all nodes that have 0 incoming edge

        }   
        
        public void CreateBuilderOrder_V2()
        {

        }
    }

    public class Project
    {
        public string Name { get; set; }
        public int Dependencis { get; set; }
        public List<Project> Children { get; set; } = new List<Project>();
        private HashSet<string> Set = new HashSet<string>();

        public Project(string name)
        {
            Name = name;
        }

        public void AddNeighbor(Project node)
        {
            if (Set.Add(node.Name)){
                Children.Add(node);
                node.Dependencis++;
            }
        }
    }
}
