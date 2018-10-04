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
    public class _1_8Tests
    {
        [TestMethod()]
        public void SetZeroTest()
        {
            var testData = new int[3, 2] { { 1, 2 }, { 0, 5 }, { 3, 4 } };

            var model = new _1_8();

            var newMatrix = model.SetZero(testData);
        }
    }
}