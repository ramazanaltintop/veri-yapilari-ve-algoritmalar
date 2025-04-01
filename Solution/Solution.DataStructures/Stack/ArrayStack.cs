using Solution.DataStructures.Array;

namespace Solution.DataStructures.Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        private readonly Array<T> _array = new Array<T>();
        public int Count { get; private set; }

        public void Clear()
        {
            if (Count == 0)
                throw new InvalidOperationException("Stack is already empty.");
            while (Count != 0)
            {
                _array.Remove();
                Count--;
            }
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Stack is empty.");
            return _array.GetLastItem();
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Stack is empty.");
            var temp = _array.Remove();
            Count--;
            return temp;
        }

        public void Push(T value)
        {
            if (value is null)
                throw new ArgumentNullException("Value cannot be null.");
            _array.Add(value);
            Count++;
        }
    }
}