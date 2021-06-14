using System;
using System.Collections.Generic;
using System.Text;

namespace TreeSearchAlgo
{
    public class TreeSearch<T>
    {
        /// <summary>
        /// Метод поиска элемента в ширину
        /// Если значение найдено, то возвращает узел с найденным значением
        /// Иначе null.
        /// </summary>
        /// <param name="top"> вершина, с которой будет запущен поиск</param>
        /// <param name="value">значение, которое нужно найти</param>
        /// <returns>первый найденный узел с заданным значением</returns>
        public TreeNode<T> BFS(TreeNode<T> top, T value)
        {
            Queue<TreeNode<T>> q = new Queue<TreeNode<T>>();
            q.Enqueue(top);
            top.Used = true;
            while (q.Count != 0)
            {
                // достаем первый элемент из очереди
                TreeNode<T> current = q.Dequeue();
                // помечаем, что в этой вершине мы уже были
                current.Used = true;
                // проверка совпадения значения
                if (current.Value.Equals(value))
                {
                    return current;
                }
                // добавляем в очередь все вершины, в которых не были
                for (int i = 0; i < current.Childs.Count; i++)
                {
                    // если эта вершина еще не обрабатывалась, то добавляем ее в очередь
                    if (current.Childs[i].Used == false)
                    {
                        q.Enqueue(current.Childs[i]);
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Метод поиска элемента в глубину
        /// Если значение найдено, то возвращает узел с найденным значением
        /// Иначе null.
        /// </summary>
        /// <param name="current"> вершина, с которой будет запущен поиск</param>
        /// <param name="value">значение, которое нужно найти</param>
        /// <returns>первый найденный узел с заданным значением</returns>        
        public TreeNode<T> DFS(TreeNode<T> current, T value)
        {
            // проверяем есть ли в узле нужное значение
            if (current.Value.Equals(value))
            {
                return current;
            }
            else
            {
                for (int i = 0; i < current.Childs.Count; i++)
                {
                    // если в этой вершине еще не были
                    if (current.Childs[i].Used == false)
                    {
                        // помечаем, что были в этой вершине
                        current.Childs[i].Used = true;
                        // запускаем поиск в глубину для данной вершины
                        DFS(current.Childs[i], value);
                    }
                }
                return null;
            }
        }
    }
}
