namespace Solution.DataStructures.Queue
{
    public class Queue<T>
    {
        private readonly IQueue<T> _queue;
        public int Count => _queue.Count;

        public Queue(QueueType type = QueueType.List)
        {
            if (type == QueueType.List)
            {
                _queue = new ListQueue<T>();
            }
            else
            {
                _queue = new LinkedListQueue<T>();
            }
        }

        public T DeQueue()
        {
            return _queue.DeQueue();
        }

        public void EnQueue(T value)
        {
            _queue.EnQueue(value);
        }

        public T Peek()
        {
            return _queue.Peek();
        }
    }

    public interface IQueue<T>
    {
        int Count { get; }
        void EnQueue(T value);
        T DeQueue();
        T Peek();
    }

    public enum QueueType
    {
        List = 0,           // List<T>
        LinkedList = 1      // DoublyLinkedList<T>
    }
}
