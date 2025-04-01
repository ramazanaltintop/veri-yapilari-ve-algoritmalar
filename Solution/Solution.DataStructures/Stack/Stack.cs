namespace Solution.DataStructures.Stack
{
    public class Stack<T>
    {
        private readonly IStack<T> _stack;
        public int Count => _stack.Count;

        public Stack(StackType type = StackType.List)
        {
            if (type == StackType.List)
            {
                _stack = new ListStack<T>();
            }
            else
            {
                _stack = new LinkedListStack<T>();
            }
        }

        public void Clear()
        {
            _stack.Clear();
        }

        public T Peek()
        {
            return _stack.Peek();
        }

        public T Pop()
        {
            return _stack.Pop();
        }

        public void Push(T value)
        {
            _stack.Push(value);
        }
    }

    public interface IStack<T>
    {
        int Count { get; }
        void Push(T value);
        T Peek();
        T Pop();
        void Clear();
    }

    public enum StackType
    {
        List = 0,           // List<T>
        LinkedList = 1,     // SinglyLinkedList<T>
    }
}
