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

        public SinglyLinkedListNode<T>? Head { get; set; }
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

        public void AddAfter(SinglyLinkedListNode<T> refNode, T value)
        {
            if (refNode is null)
            {
                throw new ArgumentException("Reference node is not found.");
            }

            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);

            var current = Head;

            while (current is not null)
            {
                if (current == refNode)
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
            if (refNode is null)
            {
                throw new ArgumentException("Reference node is not found.");
            }

            var current = Head;

            while (current is not null)
            {
                if (current == refNode)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("Reference node is not found.");
        }

        public void AddBefore(SinglyLinkedListNode<T> refNode, T value)
        {
            if (refNode is null)
            {
                throw new ArgumentException("Reference node is not found.");
            }

            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);

            var current = Head;

            while (current is not null)
            {
                if (current.Next == refNode)
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
            if (refNode is null)
            {
                throw new ArgumentException("Reference node is not found.");
            }

            var current = Head;

            while (current is not null)
            {
                if (current.Next == refNode)
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
                throw new ArgumentException("There are no nodes in the list");
            var firstData = Head.Value;
            Head = Head.Next;
            return firstData;
        }

        public T RemoveLast()
        {
            if (isHeadNull)
                throw new ArgumentException("There are no nodes in the list");
            var current = Head;
            SinglyLinkedListNode<T>? prev = null;
            if (current.Next is null)
            {
                var value = current.Value;
                Head = null;
                return value;
            }
            while (current.Next is not null)
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
                throw new ArgumentException("There are no nodes in the list");

            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            // Tek elemanlı bir listemiz varsa
            if (current.Next is null)
            {
                // Eleman bulunursa sil
                if (current.Value.Equals(value))
                {
                    Head = null;
                    return;
                }
            }

            // En az 2 elemanlı ise
            if (current.Next is not null)
            {
                prev = current;
                current = current.Next;
                // ilk eleman aranan eleman ise sil
                if (prev.Value.Equals(value))
                {
                    Head = current;
                    prev.Next = null;
                    return;
                }
            }

            // ikinci elemanın değerini kontrol ederek başlıyoruz.
            // eğer aranılan değer değilse two-pointer tekniği uygulanır.
            while (current is not null)
            {
                if (current.Value.Equals(value))
                {
                    prev.Next = current.Next;
                    current.Next = null;
                    return;
                }
                prev = current;
                current = current.Next;
            }
            throw new ArgumentException("No node found to remove.");
        }
    }
}
