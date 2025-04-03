using Solution.DataStructures.Tree.BinaryTree;
using System.Collections;

namespace Solution.DataStructures.Tree.BinarySearchTree
{
    public class BinarySearchTree<T> : IEnumerable<T>
        where T : IComparable
    {
        public Node<T> Root { get; set; }

        public BinarySearchTree()
        {
            
        }

        public BinarySearchTree(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value), "Value cannot be null.");
            var newNode = new Node<T>(value);
            if (Root is null)
            {
                Root = newNode;
            }
            else
            {
                Node<T> current = Root;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    // sol alt ağaç ise
                    if (value.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;
                        if (current is null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    // sağ alt ağaç ise
                    else
                    {
                        current = current.Right;
                        if (current is null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        
    }
}
