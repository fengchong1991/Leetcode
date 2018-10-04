using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackTheCodingInterview.Chapter_1_Arrays_and_Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_1_Arrays_and_Strings.Tests
{
    [TestClass()]
    public class _1_7Tests
    {
        [TestMethod()]
        public void RotateTest()
        {
            var test = new int[][] { new int[]{ 1, 2 }, new int[]{ 3, 4 } };

            var model = new _1_7();

            model.Rotate(test);

            Console.WriteLine();

        }

        [TestMethod()]
        public void RotateTest2()
        {
            var test = new int[][] { new int[] { 1, 2 ,3}, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };

            var model = new _1_7();

            model.Rotate(test);

            Console.WriteLine();

        }

        [TestMethod()]

        public void RotateTest3()
        {
            var test = new int[][] { new int[] { 4, 2, 3 }, new int[] { 1, 8, 4 }, new int[] { 6, 6, 7 } };

            var model = new _1_7();

            var newMatrix = model.Rotate_V2(test);


        }
    }
}