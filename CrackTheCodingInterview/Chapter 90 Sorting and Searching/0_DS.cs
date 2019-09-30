using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_90_Sorting_and_Searching
{
    public class _0_DS
    {

        /// <summary>
        /// Bubble Sort
        /// In bubble sort, we start at the beginning of the array and swap the first two elements if the first is greater
        /// than the second.Then, we go to the next pair, and so on, continuously making sweeps of the array until it is
        /// sorted.In doing so, the smaller items slowly"bubble" up to the beginning of the list.
        /// 
        /// Running time O(n2) average and worst case, memory O(1)
        /// </summary>
        public void BubbleSort()
        {

        }

        /// <summary>
        /// Selection Sort
        /// Selection sort is the child's algorithm: simple, but inefficient. Find the smallest element using a linear scan
        /// and move it to the front(swapping it with the front element). Then, find the second smallest and move it,
        /// again doing a linear scan.Continue doing this until all the elements are in place.
        /// 
        /// Running time O(n2) average and worst case, memory O(1)
        /// </summary>
        public void SelectionSort()
        {

        }

        /// <summary>
        /// Merge Sort
        /// Merge sort divides the array in half, sorts each of those halves, and then merges them back together. Each
        /// of those halves has the same sorting algorithm applied to it.Eventually, you are merging just two single element
        /// arrays.It is the "merge" part that does all the heavy lifting.
        /// 
        /// Merge Sort I Runtime: 0 ( n log ( n)) average and worst case.
        /// The space complexity of merge sort is 0( n) due to the auxiliary space used to merge parts of the array.
        /// </summary>
        public void MergeSort()
        {

        }

        /// <summary>
        /// Quick Sort
        /// 
        /// Quick Sort I Runtime: O(nlog(n)) average, O(n2) worst case. Memory: 0(log(n)).
        /// </summary>
        public void QuickSort()
        {

        }

        /// <summary>
        /// Radix Sort
        /// </summary>
        public void RadixSort()
        {

        }


        public void BinarySearch()
        {

        }
    }
}
