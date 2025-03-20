using System.Collections;

namespace Solution.DataStructures.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;

        public int Count { get; private set; }
        public int Capacity => InnerList.Length;

        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }

        public Array(params T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
                Add(item);
        }

        public Array(IEnumerable<T> collection)
        {
            InnerList = new T[collection.ToArray().Length];
            Count = 0;
            foreach (var item in collection)
                Add(item);
        }

        public void Add(T item)
        {
            if (InnerList.Length == Count)
                DoubleArray();
            InnerList[Count] = item;
            Count++;
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length * 2];
            // Solution - 1
            for (int i = 0; i < InnerList.Length; i++)
            {
                temp[i] = InnerList[i];
            }
            // Solution - 2
            //System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;
        }

        public T Remove()
        {
            if (Count == 0)
                throw new Exception("There is no more item to be removed from to the array.");
            var item = InnerList[Count - 1];
            if (Count > 0)
                Count--;
            if (InnerList.Length / 4 == Count)
                HalfArray();
            return item;
        }

        private void HalfArray()
        {
            if (InnerList.Length > 2)
            {
                var temp = new T[InnerList.Length / 2];
                for (int i = 0; i < InnerList.Length / 4; i++)
                {
                    temp[i] = InnerList[i];
                }
                InnerList = temp;
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            //return InnerList.Select(x => x).GetEnumerator();
            return InnerList.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
