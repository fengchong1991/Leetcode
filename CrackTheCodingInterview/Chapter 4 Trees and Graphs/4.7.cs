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
        // Give an array of projects and an array of dependencies, build project graph object
        public ProjectGraph SetupGraph(string[] projects, string[][] dependencies)
        {
            ProjectGraph graph = new ProjectGraph();
            
            foreach(var project in projects)
            {
                graph.CreateOrGetProject(project);
            }

            foreach(var dependency in dependencies)
            {
                graph.AddDependency(dependency[0], dependency[1]);
            }
            
            return graph;
        }

        // Running time: O(P+D) P is number of projects and D is number of dependencies
        public Project[] CreateBuildOrder(string[] projects, string[][] dependencies)
        {
            // Setup the graph
            var graph = SetupGraph(projects, dependencies);

            // Create project builder order
            var order = CreateOrder(graph);

            return order;
        }   

        public Project[] CreateOrder(ProjectGraph graph)
        {
            var order = new Project[graph.Projects.Count];

            // Add project with 0 dependencies to build order array
            var index = 0;
            foreach (var project in graph.Projects)
            {
                if (project.Dependencis == 0)
                {
                    order[index] = project;
                    index++;
                }
            }

            // Proceed each in the builder order array, i.e. find it's children and decrease their dependencies
            int processed = 0;
            while(processed < order.Length)
            {
                var project = order[processed];
                
                // If project is null, meaning their are circular dependency so it cannot be build
                if(project == null)
                {
                    throw new Exception("Cannot be built");
                }

                // If any child has zero dependecies, add this to build order array
                foreach(var p in project.Children)
                {
                    p.Dependencis--;

                    if(p.Dependencis == 0)
                    {
                        order[index] = p;
                        index++;
                    }
                }

                processed++;
            }

            return order;
        }
        
        // Use Depth first search
        public Project[] CreateBuilderOrder_V2(string[] projects, string[][] dependencies)
        {
            // Setup the graph
            var graph = SetupGraph(projects, dependencies);
            var builderOrder = new Project[graph.Projects.Count];
            var index = graph.Projects.Count - 1;

            foreach (var project in graph.Projects)
            {
                CreateOrder_V2(project, builderOrder, index);
            }

            return builderOrder;
        }

        public void CreateOrder_V2(Project project, Project[] order, int index)
        {
            if (project.Built)
            {
                return;
            }
            
            if(project.Children == null)
            {
            
            }
        }
    }
    
    // Helper classes
    public class ProjectGraph
    {
        public List<Project> Projects { get; set; } = new List<Project>();
        public Dictionary<string, Project> Map { get; set; } = new Dictionary<string, Project>();

        public Project CreateOrGetProject(string projectName)
        {
            if (!Map.ContainsKey(projectName))
            {
                var project = new Project(projectName);
                Map.Add(projectName, project);
                Projects.Add(project);
                return project;
            }
            else
            {
                return Map[projectName];
            }
        }

        public void AddDependency(string project1, string project2)
        {
            var p1 = CreateOrGetProject(project1);
            var p2 = CreateOrGetProject(project2);
            p1.AddNeighbor(p2);
        }
    }

    public class Project
    {
        public string Name { get; set; }
        public int Dependencis { get; set; }
        public bool Built { get; set; }

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
