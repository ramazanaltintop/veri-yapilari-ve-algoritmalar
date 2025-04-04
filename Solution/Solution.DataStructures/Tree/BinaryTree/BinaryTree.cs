﻿namespace Solution.DataStructures.Tree.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public List<Node<T>> list { get; private set; }

        public BinaryTree()
        {
            list = new List<Node<T>>();
        }

        public List<Node<T>> InOrder(Node<T> root)
        {
            if (root is not null)
            {
                InOrder(root.Left);
                list.Add(root);
                InOrder(root.Right);
            }
            return list;
        }

        public List<Node<T>> InOrderNonRecursiveTraversal(Node<T> root)
        {
            var result = new List<Node<T>>();
            var stack = new DataStructures.Stack.Stack<Node<T>>();
            Node<T> currentNode = root;
            bool done = false;
            while (!done)
            {
                if (currentNode is not null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else if (stack.Count == 0)
                {
                    done = true;
                }
                else
                {
                    currentNode = stack.Pop();
                    result.Add(currentNode);
                    currentNode = currentNode.Right;
                }
            }
            return result;
        }

        public List<Node<T>> PreOrder(Node<T> root)
        {
            if (root is not null)
            {
                list.Add(root);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
            return list;
        }

        public List<Node<T>> PreOrderNonRecursiveTraversal(Node<T> root)
        {
            List<Node<T>> result = new List<Node<T>>();
            if (root is null)
                throw new ArgumentNullException(nameof(root), "The tree root cannot be null.");
            var stack = new DataStructures.Stack.Stack<Node<T>>();
            stack.Push(root);
            while (stack.Count != 0)
            {
                var tmp = stack.Pop();
                result.Add(tmp);
                if (tmp.Right is not null)
                    stack.Push(tmp.Right);
                if (tmp.Left is not null)
                    stack.Push(tmp.Left);
            }
            return result;
        }

        public List<Node<T>> PostOrder(Node<T> root)
        {
            if (root is not null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                list.Add(root);
            }
            return list;
        }

        public void ClearList() => list.Clear();
    }
}
