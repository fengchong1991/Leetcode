using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_1_Arrays_and_Strings
{
    //    Zero Matrix: Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
    //column are set to 0.

    public class _1_8
    {
        public bool SetZero(int[,] matrix)
        {
            if(matrix.Length == 0)
            {
                return false;
            }

            var rowLength = matrix.GetLength(0);
            var columnLength = matrix.GetLength(1);
                        
            var rows = new bool[rowLength];
            var columns = new bool[columnLength];

            for(var i = 0; i < rowLength; i++)
            {
                for(var j = 0; j < columnLength; j++)
                {
                    if(matrix[i,j] == 0)
                    {
                        rows[i] = true;
                        columns[j] = true;
                    }
                }
            }

            for (var i = 0; i < rowLength; i++)
            {
                if (rows[i])
                {
                    for (var j = 0; j < columnLength; j++){
                        matrix[i,j] = 0;
                    }
                }
            }


            for (var i = 0; i < columnLength; i++)
            {
                if (columns[i] == true)
                {
                    for (var j = 0; j < rowLength; j++)
                    {
                        matrix[j, i] = 0;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Set first row and column to 0, then set zero based on first row and column
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public bool SetZero_V2(int[,] matrix)
        {
            return true;
        }
    }
}
