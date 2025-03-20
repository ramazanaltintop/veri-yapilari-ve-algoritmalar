using System.Collections;
using System.Net.NetworkInformation;

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

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                Add(item);
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

        public bool Remove(T item)
        {
            if (Count == 0)
                throw new Exception("There is no more item to be removed from to the array.");
            var index = 0;
            for (int i = 0; i < InnerList.Length; i++)
            {
                if (InnerList[InnerList.Length - 1].Equals(item))
                {
                    Count--;
                    break;
                }
                else if (InnerList[i].Equals(item))
                {
                    InnerList[i] = InnerList[i + 1];
                    index = i + 1;
                    Count--;
                    break;
                }
            }
            if (index != 0)
            {
                for (int i = index; i < InnerList.Length - 1; i++)
                {
                    InnerList[i] = InnerList[i + 1];
                }
                if (InnerList.Length / 4 == Count)
                    HalfArray();
            }
            else
                return false;
            return true;
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
            // Shallow Copy
            // Klonlama oldugu gibi yapilir.
            //return this.MemberwiseClone();
            // Deep Copy
            // Herseyi sifirdan olusturursunuz.
            var arr = new Array<T>();
            foreach (var item in this)
            {
                arr.Add(item);
            }
            return arr;
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
