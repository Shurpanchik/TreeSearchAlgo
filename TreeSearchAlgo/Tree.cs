using System;
using System.Collections.Generic;
using System.Text;

namespace TreeSearchAlgo
{
    /// <summary>
    /// Дерево - это связный графм без циклов. 
    /// В моей реализации дерева будет только метод Add, чтобы показать как работают алгоритмы поиска
    /// </summary>
    public class Tree<T>
    {
        //вершина дерева
        TreeNode<T> top;

        public TreeNode<T> Top { get => top; set => top = value; }

        //метод добавления нового узла.
        public void Add(TreeNode<T> node)
        {
            if (Top == null)
            {
                Top = node;
            }
            else
            {

            }
        }
    }
}
