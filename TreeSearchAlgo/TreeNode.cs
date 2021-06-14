using System;
using System.Collections.Generic;
using System.Text;

namespace TreeSearchAlgo
{
    /// <summary>
    /// Класс узла дерева
    /// В узле дерева лежит значение узла и список его детей
    /// </summary>
    public class TreeNode<T>
    {
        T value;
        List<TreeNode<T>> childs;
        bool used = false;

        public T Value { get => value; set => this.value = value; }
        public List<TreeNode<T>> Childs { get => childs; set => childs = value; }
        public bool Used { get => used; set => used = value; }
    }
}
