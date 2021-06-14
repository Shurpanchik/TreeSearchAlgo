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
            TreeNode<int> top = new TreeNode<int>(1);
            tree.Add(null,top);
            TreeSearch<int> search = new TreeSearch<int>();
            // найден элемент
            Assert.AreEqual(search.DFS(top, 1).Value, 1);
            // не найден элемент
            Assert.AreEqual(search.DFS(top, 22), null);
        }

        /// <summary>
        /// Тест дерева высоты 1
        /// </summary>
        [TestMethod]
        public void DFSTestOneLevel()
        {
            Tree<int> tree = new Tree<int>();
            TreeNode<int> top = new TreeNode<int>(22);
            tree.Add(null, top);
            // добавляем детей 
            tree.Add(top, new TreeNode<int>(1));
            tree.Add(top, new TreeNode<int>(2));
            tree.Add(top, new TreeNode<int>(3));
            tree.Add(top, new TreeNode<int>(1));
            TreeSearch<int> search = new TreeSearch<int>();
            // найден элемент
            Assert.AreEqual(search.DFS(top, 1).Value, 1);
            // не найден элемент
            Assert.AreEqual(search.DFS(top, 1).Value, null);
        }

        /// <summary>
        /// Список - вырожденное дерево
        /// </summary>
        [TestMethod]
        public void DFSTestArray()
        {
            Tree<int> tree = new Tree<int>();
            TreeNode<int> top = new TreeNode<int>(22);
            tree.Add(null, top);
            // добавляем детей 
            TreeNode<int> child1 = new TreeNode<int>(2);
            TreeNode<int> child2 = new TreeNode<int>(3);
            TreeNode<int> child3 = new TreeNode<int>(1);
            tree.Add(top, child1);
            tree.Add(child1, child2);
            tree.Add(child2, child3);
            TreeSearch<int> search = new TreeSearch<int>();
            // найден элемент
            Assert.AreEqual(search.DFS(top, 1).Value, 1);
            // не найден элемент
            Assert.AreEqual(search.DFS(top, 4), null);
        }

    }
}
