using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_1_Arrays_and_Strings
{
    //    Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
    //bytes, write a method to rotate the image by 90 degrees.Can you do this in place?

    public class _1_7
    {
        public bool Rotate(int[][] matrix)
        {

            if (matrix.Length == 0 || matrix[0].Length != matrix.Length)
            {
                return false;
            }

            var length = matrix.Length / 2;

            for(var layer = 0; layer < length; layer++)
            {
                var last = matrix.Length - 1 - layer;

                for(var i = layer; i < last; i++)
                {
                    // Save top
                    var top = matrix[layer][i];

                    // Left to top 
                    matrix[layer][i] = matrix[last - i][layer];

                    // Bottom to left
                    matrix[last-i][layer] = matrix[last][last-i];

                    // right to bottom
                    matrix[last][last-i] = matrix[i][last];

                    matrix[i][last] = top;
                }
            }

            return true;
        }

        public int[][] Rotate_V2(int[][] matrix) {

            var length = matrix.Length;

            var newMatrix = new int[3][];
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                newMatrix[i] = new int[length];
            }
            
            for(var i = 0; i< length; i++)
            {
                for(var j = 0; j < length; j++)
                {
                    newMatrix[j][length-1- i] = matrix[i][j];
                }
            }

            var arwaf = new int[3,4];

            return newMatrix;
        }
    }
}
