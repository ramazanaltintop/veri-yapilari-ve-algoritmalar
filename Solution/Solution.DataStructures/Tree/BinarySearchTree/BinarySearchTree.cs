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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
