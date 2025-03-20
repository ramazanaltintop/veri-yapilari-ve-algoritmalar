using System.Collections;

namespace Solution.Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro();
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
