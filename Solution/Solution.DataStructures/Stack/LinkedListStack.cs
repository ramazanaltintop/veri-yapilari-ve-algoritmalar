using Solution.DataStructures.LinkedList.SinglyLinkedList;

namespace Solution.DataStructures.Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        private readonly SinglyLinkedList<T> list = new SinglyLinkedList<T>();
        public int Count { get; private set; }

        public void Clear()
        {
            if (Count == 0)
                throw new InvalidOperationException("Stack is already empty.");
            list.Head = null;
            Count = 0;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Stack is empty.");
            return list.Head.Value;
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Stack is empty.");
            var temp = list.Head.Value;
            list.Head = list.Head.Next;
            Count--;
            return temp;
        }

        public void Push(T value)
        {
            if (value is null)
                throw new ArgumentNullException("Value cannot be null.");
            list.AddFirst(value);
            Count++;
        }
    }
}