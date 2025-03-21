using Solution.DataStructures.LinkedList.SinglyLinkedList;
using System.Collections;

namespace Solution.Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList1();
        }

        private static void LinkedList1()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(3);
            linkedList.AddFirst(5);
        }

        private static void GenericArray8()
        {
            var arr = new Solution.DataStructures.Array.Array<int>(1, 3, 5, 7);
            var list = new List<int>() { 9, 11, 13, 15 };

            arr.AddRange(list);

            //arr.Remove(15);
            //arr.Remove(13);
            //arr.Remove(11);
            //arr.Remove(9);
            //arr.Remove(1);
            //arr.Remove(5);
            //arr.Remove(3);
            //arr.Remove(7);

            Console.WriteLine($"{arr.Count} / {arr.Capacity}");

            foreach (var item in arr)
                Console.WriteLine(item);
        }

        private static void ShallowCopyDeepCopy()
        {
            var arr = new Solution.DataStructures.Array.Array<int>(2, 4, 6, 8);
            var crr = (Solution.DataStructures.Array.Array<int>)arr.Clone();
            //var crr = arr.Clone() as Solution.DataStructures.Array.Array<int>;

            // Klonlanmis dizi uzerinde yapilan degisikliklerin diger nesne uzerinde etkisi olmaz!
            //arr.Add(7);
            crr.Add(7);

            foreach (var item in arr)
            {
                Console.Write($"{item,-3}");
            }

            Console.WriteLine($"{arr.Count}/{arr.Capacity}");

            Console.WriteLine();

            foreach (var item in crr)
            {
                Console.Write($"{item,-3}");
            }

            Console.WriteLine($"{crr.Count}/{crr.Capacity}");
        }

        private static void GenericArray7()
        {
            var arr = new Solution
                            .DataStructures
                            .Array
                            .Array<int>();

            for (int i = 0; i < 128; i++)
            {
                arr.Add(i + 1);
                Console.WriteLine($"{i + 1} has been added to the array.");
                Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            }

            Console.WriteLine();

            for (int i = arr.Count; i >= 1; i--)
            {
                Console.WriteLine($"{arr.Remove()} has been removed from the array.");
                Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            }

            Console.WriteLine();

            foreach (var item in arr)
            {
                Console.WriteLine(arr);
            }
        }

        private static void GenericArray6()
        {
            var p1 = new Solution.DataStructures.Array.Array<int>(5, 6, 7, 8);
            var p2 = new int[] { 1, 2, 3, 4 };
            var p3 = new List<int>() { 9, 10, 11, 12 };
            var p4 = new ArrayList() { 13, 14, 15, 16 };

            var arr = new Solution
                .DataStructures
                .Array
                .Array<int>(p3);
            // p4 hata verir.

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void GenericArray5()
        {
            var arr = new Solution
                            .DataStructures
                            .Array
                            .Array<int>(10, 20, 30, 40);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        }

        private static void GenericArray4()
        {
            var arr = new Solution
                            .DataStructures
                            .Array
                            .Array<int>();

            arr.Add(25);
            arr.Add(50);
            arr.Add(75);
            arr.Add(85);
            arr.Add(91);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");

            using (IEnumerator<int> enumerator = arr.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var item = enumerator.Current;
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("---");

            arr.Where(x => x % 2 == 0)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        }

        private static void GenericArray3()
        {
            var arr = new Solution
                .DataStructures
                .Array
                .Array<int>();

            arr.Add(25);
            arr.Add(50);
            arr.Add(75);
            arr.Add(85);
            arr.Add(91);

            arr.Remove();

            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        }

        private static void GenericArray2()
        {
            var arr = new Solution
                .DataStructures
                .Array
                .Array<int>();

            arr.Add(25);
            arr.Add(50);
            arr.Add(75);

            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        }

        private static void GenericArray1()
        {
            var arr = new Solution
                            .DataStructures
                            .Array
                            .Array<int>();

            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        }

        private static void Intro()
        {
            // Array
            char[] arrChar = new char[3];
            var arrChar1 = new char[3];
            var arrChar2 = new char[7] { 'r', 'a', 'm', 'a', 'z', 'a', 'n' };
            var arrChar3 = new char[] { 'a', 'l', 't', 'i', 'n', 't', 'o', 'p' };
            var arrInt = Array.CreateInstance(typeof(int), 4);
            arrInt.SetValue(10, 0); // arrInt[0] = 10;
            arrInt.GetValue(0); // 10

            // ArrayList
            // 10 --> boxing --> object
            // R --> boxing --> object
            // object --> unboxing --> int
            var arrObj = new ArrayList();
            arrObj.Add(10);
            arrObj.Add('R');
            //var c = ((int)arrObj[0] + 20);
            Console.WriteLine(arrObj.Count);

            // List<T> - T:Type
            var arrInt1 = new List<int>();
            arrInt1.Add(25);
            arrInt1.AddRange(new int[] { 1, 2, 3 });
            arrInt1.RemoveAt(0);
            foreach (var item in arrInt1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrInt1.Count);
        }
    }
}
