using Solution.DataStructures.LinkedList.DoublyLinkedList;

namespace Solution.DataStructures.Queue
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private readonly DoublyLinkedList<T> _list = new DoublyLinkedList<T>();
        public int Count { get; private set; }

        public T DeQueue()
        {
            if (Count == 0)
                throw new InvalidOperationException("Queue is empty.");
            var temp = _list.RemoveFirst();
            Count--;
            return temp;
        }

        public void EnQueue(T value)
        {
            if (value is null)
                throw new ArgumentNullException("Value cannot be null.");
            _list.AddLast(value);
            Count++;
        }

        public T Peek() => Count == 0 
            ? throw new InvalidOperationException("Queue is empty.") 
            : _list.Head.Value;
    }
}