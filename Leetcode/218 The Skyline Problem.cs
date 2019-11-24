using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _218_The_Skyline_Problem
    {
        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            var buildingPoints = new List<IList<int>>();

            var result = new List<IList<int>>();

            foreach (var item in buildings)
            {
                buildingPoints.Add(new List<int>() { item[0], -item[2] });
                buildingPoints.Add(new List<int>() { item[1], item[2] });
            }

            buildingPoints.Sort((a, b) =>
            {
                if (a[0] != b[0])
                {
                    return a[0].CompareTo(b[0]);
                }
                else
                {
                    return a[1] - b[1];
                }
            });

            var sortedDic = new SortedDictionary<int, int>(new DescendingComparer<int>())
            {
                { 0, 0 }
            };

            int preMax = 0;

            foreach (var bp in buildingPoints)
            {
                if (bp[1] < 0)
                {
                    if (sortedDic.ContainsKey(-bp[1]))
                    {
                        sortedDic[-bp[1]]++;
                    }
                    else
                    {
                        sortedDic.Add(-bp[1], 1);
                    }
                }
                else
                {
                    if (sortedDic.ContainsKey(bp[1]) && sortedDic[bp[1]] > 1)
                    {
                        sortedDic[bp[1]]--;
                    }
                    else
                    {
                        sortedDic.Remove(bp[1]);
                    }
                }

                var curHeight = sortedDic.First();
                if (curHeight.Key != preMax)
                {
                    result.Add(new int[] { bp[0], curHeight.Key });
                    preMax = curHeight.Key;
                }
            }

            return result;
        }

        public class DescendingComparer<T> : IComparer<T> where T : IComparable<T>
        {
            public int Compare(T x, T y) { return y.CompareTo(x); }
        }
    }

        public class DescendingComparer<T> : IComparer<T> where T : IComparable<T>
        {
            public int Compare(T x, T y) { return y.CompareTo(x); }
        }
    }
}
