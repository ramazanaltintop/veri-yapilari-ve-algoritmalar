namespace Solution.DataStructures.Stack
{
    public class ListStack<T> : IStack<T>
    {
        private readonly List<T> list = new List<T>();
        public int Count { get; private set; }

        public void Clear()
        {
            if (Count == 0)
                throw new InvalidOperationException("Stack is already empty.");
            while (Count != 0)
            {
                list.RemoveAt(list.Count - 1);
                Count--;
            }
        }

        public T Peek()
        {
            if (Count > 0)
                return list[list.Count - 1];
            throw new InvalidOperationException("Stack is empty.");
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var temp = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                Count--;
                return temp;
            }
            throw new InvalidOperationException("Stack is empty.");
        }

        public void Push(T value)
        {
            if (value is null)
                throw new ArgumentNullException("Value cannot be null.");
            list.Add(value);
            Count++;
        }
    }
}