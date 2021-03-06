﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackTheCodingInterview.Chapter_4_Trees_and_Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_4_Trees_and_Graphs.Tests
{
    [TestClass()]
    public class _4_3Tests
    {
        [TestMethod()]
        public void CreateLinkedListsTest()
        {

            var model = new _4_2();

            var array = new int[] { 3, 5, 11, 14, 15, 30 };

            var tree = model.CreateBinaryTree(array);


            var testModel = new _4_3();
            
            var lists = testModel.CreateLinkedLists(tree);
        }
    }
}