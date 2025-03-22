namespace Solution.DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
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
    }
}
