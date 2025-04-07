namespace Solution.DataStructures.Tree.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }

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

        public List<Node<T>> PostOrderNonRecursiveTraversal(Node<T> root)
        {
            var result = new List<Node<T>>();
            var stack = new DataStructures.Stack.Stack<Node<T>>();
            if (root is null)
                throw new ArgumentNullException(nameof(root), "The tree root cannot be null.");
            Node<T> temp;
            stack.Push(root);
            int count = 0;
            while (true)
            {
                temp = stack.Peek();

                Node<T> isFound = result.Where(n => n == temp.Left || n == temp.Right).FirstOrDefault();

                if (isFound is null)
                {
                    if (temp.Right is not null)
                    {
                        stack.Push(temp.Right);
                    }
                    if (temp.Left is not null)
                    {
                        stack.Push(temp.Left);
                    }
                }
                else
                {
                    temp = stack.Pop();
                    result.Add(temp);
                    if (stack.Count == 0)
                        break;
                    isFound = null;
                }

                if (temp.Right is null && temp.Left is null && count < 2)
                {
                    temp = stack.Pop();
                    result.Add(temp);
                    count++;
                    if (count == 2)
                    {
                        temp = stack.Pop();
                        result.Add(temp);
                        count = 0;
                    }
                }
                
            }
            return result;
        }

        public List<Node<T>> LevelOrderNonRecursiveTraversal(Node<T> root)
        {
            if (root is null)
                throw new ArgumentNullException(nameof(root), "The tree root cannot be null.");
            var result = new List<Node<T>>();
            var queue = new DataStructures.Queue.Queue<Node<T>>();
            queue.EnQueue(root);
            while (queue.Count != 0)
            {
                var temp = queue.DeQueue();
                result.Add(temp);
                if (temp.Left is not null)
                    queue.EnQueue(temp.Left);
                if (temp.Right is not null)
                    queue.EnQueue(temp.Right);
            }
            return result;
        }

        public void ClearList() => list.Clear();

        public static int MaxDepth(Node<T> root)
        {
            if (root is null)
                return 0;
            int leftDepth = MaxDepth(root.Left);
            int rightDepth = MaxDepth(root.Right);

            return (leftDepth > rightDepth)
                ? leftDepth + 1
                : rightDepth + 1;
        }

        public Node<T> DeepestNode(Node<T> root)
        {
            Node<T> temp = null;
            if (root is null)
                throw new ArgumentNullException(nameof(root), "The tree root cannot be null.");
            var queue = new DataStructures.Queue.Queue<Node<T>>();
            queue.EnQueue(root);
            while (queue.Count > 0)
            {
                temp = queue.DeQueue();
                if (temp.Left is not null)
                    queue.EnQueue(temp.Left);
                if (temp.Right is not null)
                    queue.EnQueue(temp.Right);
            }
            return temp;
        }
    }
}
