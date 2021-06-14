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
        public void Add(TreeNode<T> parent, TreeNode<T> node)
        {
            // если нет родителя, значит - это вершина дерева
            if (parent == null)
            {
                Top = node;
            }
            else
            {
                // добавляем родителю ребенка
                parent.Childs.Add(node);
            }
        }
    }
}
