using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackTheCodingInterview.Chapter_4_Trees_and_Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs.Tests
{
    [TestClass()]
    public class _4_7Tests
    {
        [TestMethod()]
        public void CreateBuildOrderTest()
        {
            var model = new _4_7();

            var projects = new string[] { "a", "b", "c", "d", "e", "f" };

            var dependencies = new string[][]
            {
                new string[]{ "a", "d" },
                new string[]{ "f", "b" },
                new string[]{ "b", "f" },
                new string[]{ "b", "d" },
                new string[]{ "f", "a" },
                new string[]{ "d", "c" },
            };

            var ordre = model.CreateBuildOrder(projects, dependencies);
        }
    }
}