using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeSearchAlgo;

namespace TreeSearchAlgoTests
{
    [TestClass]
    public class BFSTests
    {
        [TestMethod]
        public void BFSTestOnlyTop()
        {
            Tree<int> tree = new Tree<int>();
            TreeNode<int> top = new TreeNode<int>(1);
            tree.Add(null,top);
            TreeSearch<int> search = new TreeSearch<int>();
            // найден элемент
            Assert.AreEqual(search.BFS(top, 1).Value, 1);
            // не найден элемент
            Assert.AreEqual(search.BFS(top, 22), null);
        }

        /// <summary>
        /// Тест дерева с высотой 1
        /// </summary>
        [TestMethod]
        public void BFSTestOneLevel()
        {
            Tree<int> tree = new Tree<int>();
            TreeNode<int> top = new TreeNode<int>(22);
            tree.Add(null, top);
            // добавляем детей 
            tree.Add(top,new TreeNode<int>(2));
            tree.Add(top, new TreeNode<int>(3));
            tree.Add(top, new TreeNode<int>(1));
            TreeSearch<int> search = new TreeSearch<int>();
            // найден элемент
            Assert.AreEqual(search.BFS(top, 1).Value, 1);
            // не найден элемент
            Assert.AreEqual(search.BFS(top, 4), null);
        }

        /// <summary>
        /// Список - вырожденное дерево
        /// </summary>
        [TestMethod]
        public void BFSTestArray()
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
            Assert.AreEqual(search.BFS(top, 1).Value, 1);
            // не найден элемент
            Assert.AreEqual(search.BFS(top, 4), null);
        }

        /// <summary>
        /// У одной вершины 2 родителей
        /// </summary>
        [TestMethod]
        public void BFSTestTwoParent()
        {
            Tree<int> tree = new Tree<int>();
            TreeNode<int> top = new TreeNode<int>(22);
            tree.Add(null, top);
            // добавляем детей 
            TreeNode<int> child1 = new TreeNode<int>(2);
            TreeNode<int> child2 = new TreeNode<int>(3);
            TreeNode<int> child3 = new TreeNode<int>(1);
            TreeNode<int> child4 = new TreeNode<int>(4);
            tree.Add(top, child1);
            tree.Add(child1, child2);
            tree.Add(child1, child3);
            tree.Add(child2, child4);
            tree.Add(child3, child4);
            TreeSearch<int> search = new TreeSearch<int>();
            // найден элемент
            Assert.AreEqual(search.BFS(top, 1).Value, 1);
            // не найден элемент
            Assert.AreEqual(search.BFS(top, 4), null);
        }
    }
}

