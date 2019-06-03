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
    public class _5_1Tests
    {
        [TestMethod()]
        public void BitInsert_Test()
        {
            var model = new _5_1();

            var result = model.BitInsert(40, 5, 3, 1);
            Assert.AreEqual(42, result);
        }
    }
}
