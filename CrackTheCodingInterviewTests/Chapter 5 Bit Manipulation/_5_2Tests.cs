using CrackTheCodingInterview.Chapter_5_Bit_Manipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterviewTests.Chapter_5_Bit_Manipulation
{
    [TestClass()]
    public class _5_2Tests
    {
        [TestMethod()]
        public void BinaryToString_Test()
        {
            var model = new _5_2();

            var result = model.BinaryToString(0.625);
            Assert.AreEqual(".101", result);
        }
    }
}
