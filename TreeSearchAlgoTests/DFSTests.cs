using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TreeSearchAlgo;

namespace TreeSearchAlgoTests
{

    [TestClass]
    public class DFSTests
    {
        [TestMethod]
        public void DFSTestOnlyTop()
        {
            Tree<int> tree = new Tree<int>();
            TreeNode<int> top = new TreeNode<int>();
            top.Value = 1;
            tree.Add(top);
            TreeSearch<int> search = new TreeSearch<int>();
            // найден элемент
            Assert.AreEqual(search.DFS(top, 1).Value, 1);
            // не найден элемент
            Assert.AreEqual(search.DFS(top, 22), null);
        }

        /// <summary>
        /// Требует доработки
        /// </summary>
        //[TestMethod]
        public void DFSTestArray()
        {
            Tree<int> tree = new Tree<int>();
            TreeNode<int> top = new TreeNode<int>();
            top.Value = 22;
            tree.Add(top);
            TreeSearch<int> search = new TreeSearch<int>();
            // найден элемент
            Assert.AreEqual(search.DFS(top, 1).Value, 1);
            // не найден элемент
            Assert.AreEqual(search.DFS(top, 1).Value, null);
        }
    }
}
