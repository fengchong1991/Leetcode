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
    public class _1_5Tests
    {
        [TestMethod()]
        public void OneOrZeroAwayTest()
        {
            var model = new _1_5();

            Assert.AreEqual(model.OneOrZeroAway("pale","ale"), true);
        }
    }
}