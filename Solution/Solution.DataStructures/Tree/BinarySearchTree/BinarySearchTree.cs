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

        public Node<T> FindMin(Node<T> root)
        {
            if (root is null)
                throw new ArgumentNullException(nameof(root), "The tree root cannot be null.");
            Node<T> current = root;
            while (current.Left is not null)
                current = current.Left;
            return current;
        }

        public Node<T> FindMax(Node<T> root)
        {
            if (root is null)
                throw new ArgumentNullException(nameof(root), "The tree root cannot be null.");
            Node<T> current = root;
            while (current.Right is not null)
            {
                current = current.Right;
            }
            return current;
        }

        public Node<T> Find(Node<T> root, T key)
        {
            if (root is null)
                throw new ArgumentNullException(nameof(root), "The tree root cannot be null.");
            Node<T> current = root;
            while (key.CompareTo(current.Value) != 0)
            {
                if (key.CompareTo(current.Value) < 0)
                    current = current.Left;
                else
                    current = current.Right;
                if (current is null)
                    throw new KeyNotFoundException("Searched key not found.");
            }
            return current;
        }

        public Node<T> Remove(Node<T> root, T key)
        {
            // Ağacın kökünün null olup olmadığını kontrol et
            if (root is null)
                throw new ArgumentNullException(nameof(root), "The tree root is cannot be null.");

            // Aranan değer kökün değerinden küçükse sol alt ağaçtan ilerle
            if (key.CompareTo(root.Value) < 0)
            {
                root.Left = Remove(root.Left, key);
            }
            // Aranan değer kökün değerinden büyükse sağ alt ağaçtan ilerle
            else if (key.CompareTo(root.Value) > 0)
            {
                root.Right = Remove(root.Right, key);
            }
            // aranan değer bulunursa silme işlemine geç
            else
            {
                // silinecek düğüm
                // tek çocuk ya da
                // çocuksuz ise
                if (root.Left is null)
                    return root.Right;
                else if (root.Right is null)
                    return root.Left;
                // aksi halde 2 çocuk var
                root.Value = FindMin(root.Right).Value;
                root.Right = Remove(root.Right, root.Value);
            }
            return root;
        }
    }
}
