namespace Solution.DataStructures.Queue
{
    public class ListQueue<T> : IQueue<T>
    {
        private readonly List<T> _list = new List<T>();
        public int Count { get; private set; }

        public T DeQueue()
        {
            if (Count == 0)
                throw new InvalidOperationException("Queue is empty.");
            var temp = _list[0];
            _list.RemoveAt(0);
            Count--;
            return temp;
        }

        public void EnQueue(T value)
        {
            if (value is null)
                throw new ArgumentNullException("Value cannot be null.");
            _list.Add(value);
            Count++;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Queue is empty.");
            return _list[0];
        }
    }
}