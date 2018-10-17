using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackTheCodingInterview.Chapter_3_Stacks_and_Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_3_Stacks_and_Queues.Tests
{
    [TestClass()]
    public class StackSetForPlatesTests
    {
        [TestMethod()]
        public void StackSetForPlatesTest()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void PushTest()
        {
            var model = new StackSetForPlates(3);
            model.Push(5);

            model.Push(5);
            model.Push(4);
            model.Push(6);
            model.Push(12);
            model.Push(12);
            model.Push(612);
            model.Push(55);
            model.Push(6);

            Assert.AreEqual(model._stacks.Count, 3);
        }

        [TestMethod()]
        public void PopTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCurrentOneTest()
        {
            var model = new StackSetForPlates(3);

            Assert.AreEqual(model.GetCurrentOne(), null);
        }
    }
}