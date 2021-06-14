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
            TreeNode<int> top = new TreeNode<int>();
            top.Value = 1;
            tree.Add(top);
            TreeSearch<int> search = new TreeSearch<int>();
            // ������ �������
            Assert.AreEqual(search.BFS(top, 1).Value, 1);
            // �� ������ �������
            Assert.AreEqual(search.BFS(top, 22), null);
        }

        /// <summary>
        /// ������� ���������
        /// </summary>
        //[TestMethod]
        public void BFSTestArray()
        {
            Tree<int> tree = new Tree<int>();
            TreeNode<int> top = new TreeNode<int>();
            top.Value = 22;
            tree.Add(top);
            TreeSearch<int> search = new TreeSearch<int>();
            // ������ �������
            Assert.AreEqual(search.BFS(top, 1).Value, 1);
            // �� ������ �������
            Assert.AreEqual(search.BFS(top, 1).Value, null);
        }
    }
}

