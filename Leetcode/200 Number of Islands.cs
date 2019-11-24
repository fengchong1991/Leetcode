using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _200_Number_of_Islands
    {

        // DFS
        // Running time O(MN)
        // Space O(MN)
        public int NumIslands(char[][] grid)
        {

            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            // DFS, recursive
            var visited = new bool[grid.Length][];

            var islandCount = 0;

            for (var i = 0; i < visited.Length; i++)
            {
                visited[i] = new bool[grid[0].Length];
            }

            for (var i = 0; i < visited.Length; i++)
            {
                for (var j = 0; j < visited[i].Length; j++)
                {
                    if (visited[i][j] == false && grid[i][j] == '1')
                    {
                        DFS(grid, visited, i, j);
                        islandCount++;
                    }
                }
            }

            return islandCount;
        }

        public void DFS(char[][] grid, bool[][] visited, int i, int j)
        {

            if (grid[i][j] == '0' || visited[i][j])
            {
                return;
            }

            visited[i][j] = true;

            if (i + 1 < grid.Length)
            {
                DFS(grid, visited, i + 1, j);
            }

            if (j + 1 < grid[i].Length)
            {
                DFS(grid, visited, i, j + 1);
            }

            if (i - 1 >= 0)
            {
                DFS(grid, visited, i - 1, j);
            }

            if (j - 1 >= 0)
            {
                DFS(grid, visited, i, j - 1);
            }
        }



        // BFS
        public int NumIslands(char[][] grid)
        {

            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            var visited = new bool[grid.Length][];

            for (var i = 0; i < visited.Length; i++)
            {
                visited[i] = new bool[grid[0].Length];
            }

            var islandCount = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1' && visited[i][j] == false)
                    {
                        Bfs(grid, visited, i, j);
                        islandCount++;
                    }
                }
            }

            return islandCount;
        }


        public void Bfs(char[][] grid, bool[][] visited, int i, int j)
        {

            var queue = new Queue<Tuple<int, int>>();

            queue.Enqueue(new Tuple<int, int>(i, j));

            while (queue.Count > 0)
            {

                var node = queue.Dequeue();

                if (node.Item1 < 0 || node.Item1 >= grid.Length || node.Item2 < 0 || node.Item2 >= grid[0].Length || visited[node.Item1][node.Item2] || grid[node.Item1][node.Item2] == '0')
                {
                    continue;
                }

                visited[node.Item1][node.Item2] = true;

                queue.Enqueue(new Tuple<int, int>(node.Item1 + 1, node.Item2));
                queue.Enqueue(new Tuple<int, int>(node.Item1, node.Item2 + 1));
                queue.Enqueue(new Tuple<int, int>(node.Item1 - 1, node.Item2));
                queue.Enqueue(new Tuple<int, int>(node.Item1, node.Item2 - 1));

            }
        }
    }
}
