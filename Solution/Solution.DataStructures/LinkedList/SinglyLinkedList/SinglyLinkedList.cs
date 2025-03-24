using System.Collections;

namespace Solution.DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedList()
        {

        }

        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.AddLast(item);
            }
        }

        public SinglyLinkedListNode<T> Head { get; set; }
        private bool isHeadNull => Head == null;

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if (isHeadNull)
            {
                Head = newNode;
                return;
            }

            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);

            var current = Head;

            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("Reference node is not found.");
        }

        public void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if (newNode == null || refNode == null)
            {
                throw new ArgumentNullException();
            }

            var current = Head;

            while (current != null)
            {
                if (current.Equals(refNode))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("Reference node is not found.");
        }

        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);

            var current = Head;

            while (current != null)
            {
                if (current.Next.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("Reference node is not found.");
        }

        public void AddBefore(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if (refNode == null || newNode == null)
            {
                throw new ArgumentNullException();
            }

            var current = Head;

            while (current != null)
            {
                if (current.Next.Equals(refNode))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }

            throw new ArgumentException("Reference node is not found.");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception("No node found to remove!");
            var firstData = Head.Value;
            Head = Head.Next;
            return firstData;
        }

        public T RemoveLast()
        {
            // Solution - 1
            //var current = Head;
            //while (current.Next != null)
            //{
            //    if (current.Next.Next == null)
            //    {
            //        var lastData = current.Next.Value;
            //        current.Next = null;
            //        return lastData;
            //    }
            //    current = current.Next;
            //}
            //throw new Exception("No found to remove.");
            // Solution - 2
            var current = Head;
            SinglyLinkedListNode<T> prev = null;
            if (current.Next == null)
            {
                var value = current.Value;
                Head = null;
                return value;
            }
            while (current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            var lastData = prev.Next.Value;
            prev.Next = null;
            return lastData;
        }

        public void Remove(T value)
        {
            if (isHeadNull)
                throw new Exception("Underflow! No found to remove.");
            if (value == null)
                throw new ArgumentNullException();

            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            do
            {
                if (current.Value.Equals(value))
                {
                    // son eleman mı?
                    if (current.Next == null)
                    {
                        // head
                        if (prev == null)
                        {
                            Head = null;
                            return;
                        }
                        // son eleman
                        else
                        {
                            prev.Next = null;
                            return;
                        }
                    }
                    else
                    {
                        // head
                        if (prev == null)
                        {
                            Head = Head.Next;
                            return;
                        }
                        // ara düğüm
                        else
                        {
                            prev.Next = current.Next;
                            return;
                        }
                    }
                }
                prev = current;
                current = current.Next;
            } while (current != null);

            throw new ArgumentException("The value could not be found");
        }
    }
}
