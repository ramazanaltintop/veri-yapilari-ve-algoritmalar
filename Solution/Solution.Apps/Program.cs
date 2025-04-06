using Solution.DataStructures.LinkedList.DoublyLinkedList;
using Solution.DataStructures.LinkedList.SinglyLinkedList;
using Solution.DataStructures.Tree.BinarySearchTree;
using Solution.DataStructures.Tree.BinaryTree;
using System.Collections;

namespace Solution.Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var BST = new BinarySearchTree<int>(new int[] { 60, 40, 70, 20, 45, 65, 85, 50});

            var binaryTree = new BinaryTree<int>();

            binaryTree
                .InOrder(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));

            binaryTree.ClearList();

            Console.WriteLine();

            BST.Remove(BST.Root, 70);

            binaryTree
                .InOrder(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));
        }

        private static void BSTMinMaxFind()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });

            Console.WriteLine($"Minimum value: {BST.FindMin(BST.Root)}");
            Console.WriteLine($"Maximum value: {BST.FindMax(BST.Root)}");

            Node<int> node = BST.Find(BST.Root, 16);
            Console.WriteLine($"{node.Value} node is found!");
            Console.WriteLine($"Node's Left: {node.Left.Value}\n" +
                $"Node's Right: {node.Right.Value}");
        }

        private static void LevelOrderTraversal()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            var binaryTree = new BinaryTree<int>();

            binaryTree
                .LevelOrderNonRecursiveTraversal(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));

            Console.WriteLine();

            BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 21, 37, 99, 2, 10, 20, 22, 32, 39, 55, 101 });

            binaryTree.ClearList();

            binaryTree
                .LevelOrderNonRecursiveTraversal(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));
        }

        private static void PostOrderTraversal()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            var binaryTree = new BinaryTree<int>();

            binaryTree
                .PostOrder(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));

            Console.WriteLine();

            binaryTree
                .PostOrderNonRecursiveTraversal(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));

            Console.WriteLine();


            BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 21, 37, 99, 2, 10, 20, 22, 32, 39, 55, 101 });

            binaryTree.ClearList();
            binaryTree
                .PostOrder(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));

            Console.WriteLine();

            binaryTree
                .PostOrderNonRecursiveTraversal(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));
        }

        private static void PreOrderTraversal()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            var binaryTree = new BinaryTree<int>();

            binaryTree
                .PreOrder(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));

            Console.WriteLine();

            binaryTree
                .PreOrderNonRecursiveTraversal(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));
        }

        private static void InOrderTraversal()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            var binaryTree = new BinaryTree<int>();

            binaryTree
                .InOrder(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));

            Console.WriteLine();

            binaryTree
                .InOrderNonRecursiveTraversal(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));
        }

        private static void BinaryTree()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            //List<Node<int>> list = new BinaryTree<int>().InOrder(BST.Root);

            //foreach (var node in list)
            //{
            //    Console.WriteLine(node);
            //}

            var binaryTree = new BinaryTree<int>();

            binaryTree
                .InOrder(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));

            binaryTree.ClearList();

            Console.WriteLine();

            binaryTree
                .PreOrder(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));

            Console.WriteLine();

            binaryTree.ClearList();

            binaryTree
                .PostOrder(BST.Root)
                .ForEach(n => Console.Write($"{n,-4}"));
        }

        private static void Queue()
        {
            var numbers = new int[] { 10, 20, 30, 40 };
            var queue1 = new DataStructures.Queue.Queue<int>();
            var queue2 = new DataStructures.Queue.Queue<int>(DataStructures.Queue.QueueType.LinkedList);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                queue1.EnQueue(number);
                queue2.EnQueue(number);
            }

            Console.WriteLine("\nCount:");
            Console.WriteLine($"queue1: {queue1.Count}");
            Console.WriteLine($"queue2: {queue2.Count}");

            Console.WriteLine("\nDeQueue:");
            Console.WriteLine($"{queue1.DeQueue()} has been removed from the queue1.");
            Console.WriteLine($"{queue2.DeQueue()} has been removed from the queue2.");

            Console.WriteLine("\nPeek:");
            Console.WriteLine($"queue1: {queue1.Peek()}");
            Console.WriteLine($"queue2: {queue2.Peek()}");

            Console.WriteLine("\nCount:");
            Console.WriteLine($"queue1: {queue1.Count}");
            Console.WriteLine($"queue2: {queue2.Count}");
        }

        private static void PostfixWithStack()
        {
            // Expected : -4
            Console.WriteLine(PostfixExample.Run("231*+9-"));
        }

        private static void Stack()
        {
            var charSet = new char[] { 'r', 'a', 'm', 'a', 'z', 'a', 'n' };
            var stack1 = new DataStructures.Stack.Stack<char>(DataStructures.Stack.StackType.List);
            var stack2 = new DataStructures.Stack.Stack<char>(DataStructures.Stack.StackType.LinkedList);
            var stack3 = new DataStructures.Stack.Stack<char>(DataStructures.Stack.StackType.Array);

            foreach (char c in charSet)
            {
                Console.WriteLine(c);
                stack1.Push(c);
                stack2.Push(c);
                stack3.Push(c);
            }

            Console.WriteLine("\nPeek");
            Console.WriteLine($"Stack1: {stack1.Peek()}");
            Console.WriteLine($"Stack2: {stack2.Peek()}");
            Console.WriteLine($"Stack3: {stack3.Peek()}");

            Console.WriteLine("\nCount");
            Console.WriteLine($"Stack1: {stack1.Count}");
            Console.WriteLine($"Stack2: {stack2.Count}");
            Console.WriteLine($"Stack3: {stack3.Count}");

            Console.WriteLine("\nPop");
            Console.WriteLine($"{stack1.Pop()} has been removed from the stack1.");
            Console.WriteLine($"{stack2.Pop()} has been removed from the stack2.");
            Console.WriteLine($"{stack3.Pop()} has been removed from the stack3.");

            Console.WriteLine("\nCount");
            Console.WriteLine($"Stack1: {stack1.Count}");
            Console.WriteLine($"Stack2: {stack2.Count}");
            Console.WriteLine($"Stack3: {stack3.Count}");

            Console.WriteLine("\nClear");
            stack1.Clear();
            stack2.Clear();
            stack3.Clear();

            Console.WriteLine("\nCount");
            Console.WriteLine($"Stack1: {stack1.Count}");
            Console.WriteLine($"Stack2: {stack2.Count}");
            Console.WriteLine($"Stack3: {stack3.Count}");
        }

        private static void DoublyLinkedList10()
        {
            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            linkedList.Remove(5);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

        private static void DoublyLinkedList9()
        {
            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            Console.WriteLine($"{linkedList.RemoveLast()} has been removed from the list.");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

        private static void DoublyLinkedList8()
        {
            var list = new DoublyLinkedList<char>(new List<char>() { 'a', 'b', 'c' });
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****");
            list = new DoublyLinkedList<char>(new char[] { 'r', 'm', 'z' });

            Console.WriteLine($"{list.RemoveFirst()} has been removed from the list!...");
            Console.WriteLine($"{list.RemoveFirst()} has been removed from the list!...");
            Console.WriteLine($"{list.RemoveFirst()} has been removed from the list!...");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void DoublyLinkedList7()
        {
            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

        private static void DoublyLinkedList6()
        {
            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            linkedList.AddBefore(linkedList.Head.Next.Next, new DoublyLinkedListNode<int>(3));
        }

        private static void DoublyLinkedList5()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(10);
            list.AddBefore(list.Head, 5);
        }

        private static void DoublyLinkedList4()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(10);

            list.AddBefore(list.Head, new DoublyLinkedListNode<int>(8));
            list.AddLast(12);
            list.AddLast(14);
            list.AddLast(16);
            list.AddFirst(6);
            // 6 8 10 12 14 16
            list.AddBefore(list.Head.Next.Next.Next.Next, new DoublyLinkedListNode<int>(13));
        }

        private static void DoublyLinkedList3()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(5);
            //list.AddLast(15);
            //list.AddLast(20);

            //DoublyLinkedListNode<int> newNode = new DoublyLinkedListNode<int>(10);

            //list.AddAfter(list.Head, newNode);
            list.AddAfter(list.Head, 12);
        }

        private static void DoublyLinkedList2()
        {
            var list = new DoublyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddFirst(4);
            // Expected : 4 <-> 1 <-> 2 <-> 3
        }

        private static void DoublyLinkedList1()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
        }

        private static void SinglyLinkedList12()
        {
            var linkedList = new SinglyLinkedList<int>(new int[] { 23, 44, 32, 55 });
            linkedList.Remove(32);
            linkedList.Remove(55);
            linkedList.Remove(23);
            //linkedList.Remove(13);
            linkedList.Remove(44);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

        private static void SinglyLinkedList11()
        {
            var rnd = new Random();
            var initial = Enumerable.Range(1, 5).OrderBy(x => rnd.Next()).ToList();
            var list = new SinglyLinkedList<int>(initial);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****");

            Console.WriteLine($"{list.RemoveLast()} has been removed");
            Console.WriteLine($"{list.RemoveLast()} has been removed");
            Console.WriteLine($"{list.RemoveLast()} has been removed");
            Console.WriteLine($"{list.RemoveLast()} has been removed");
            Console.WriteLine($"{list.RemoveLast()} has been removed");
        }

        private static void SinglyLinkedList10()
        {
            var rnd = new Random();
            var initial = Enumerable.Range(1, 5).OrderBy(x => rnd.Next()).ToList();
            var list = new SinglyLinkedList<int>(initial);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.RemoveFirst();
            list.RemoveFirst();

            Console.WriteLine("*****");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }

        private static void LINQ()
        {
            // Language Integrated Query - LINQ
            var rnd = new Random();
            var initial = Enumerable.Range(1, 10).OrderBy(x => rnd.Next()).ToList();
            var linkedList = new SinglyLinkedList<int>(initial);

            var q = from item in linkedList
                    where item % 2 == 1
                    select item;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            linkedList.Where(x => x > 5)
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }

        private static void SinglyLinkedList9()
        {
            // diziye gore calisir
            var arr = new char[] { 'r', 'a', 'm' };
            //var arrList = new ArrayList(arr);
            var list = new List<char>(arr);
            // dinamik bellek yonetimi yapar.
            var cLinkedList = new LinkedList<char>(arr);
            list.AddRange(new char[] { 'd', 'e', 'f' });

            // kendi yazdigimiz sinif
            //var linkedList = new SinglyLinkedList<char>(arr);
            var linkedList = new SinglyLinkedList<char>(list);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var charset = new List<char>(linkedList);
            foreach (var item in charset)
            {
                Console.Write(item + " ");
            }
        }

        private static void SinglyLinkedList8()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);

            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}

            using (IEnumerator<int> enumerator = linkedList.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var item = enumerator.Current;
                    Console.WriteLine(item);
                }
            }
        }

        private static void SinglyLinkedList7()
        {
            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***");

            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

        private static void SinglyLinkedList6()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);
            // 4 > 3 > 2 > 1

            SinglyLinkedListNode<int> node = new SinglyLinkedListNode<int>(5);

            linkedList.AddBefore(linkedList.Head.Next.Next.Next, node);
            // Expected: 4 > 3 > 2 > (5) > 1
        }

        private static void SinglyLinkedList5()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);
            // 4 > 3 > 2 > 1

            linkedList.AddBefore(linkedList.Head.Next.Next.Next, 5);
            // Expected: 4 > 3 > 2 > (5) > 1
        }

        private static void SinglyLinkedList4()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(3);
            linkedList.AddFirst(5);
            // 5 > 3 > 1 => O(1)

            linkedList.AddLast(6);
            linkedList.AddLast(7);
            // 5 > 3 > 1 > 6 > 7 => O(n)

            linkedList.AddAfter(linkedList.Head.Next, 9);
            // 5 > 3 > (9) > 1 > 6 > 7

            linkedList.AddAfter(linkedList.Head.Next.Next, 11);
            // 5 > 3 > 9 > (11) > 1 > 6 > 7

            SinglyLinkedListNode<int> node = new SinglyLinkedListNode<int>(13);

            // 1'den sonra 13 eklemeye calisalim.
            linkedList.AddAfter(linkedList.Head.Next.Next.Next.Next, node);
            // Expected = 5 > 3 > 9 > 11 > 1 > (13) > 6 > 7
        }

        private static void SinglyLinkedList3()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(3);
            linkedList.AddFirst(5);
            // 5 > 3 > 1 => O(1)

            linkedList.AddLast(6);
            linkedList.AddLast(7);
            // 5 > 3 > 1 > 6 > 7 => O(n)

            linkedList.AddAfter(linkedList.Head.Next, 9);
            // 5 > 3 > (9) > 1 > 6 > 7

            linkedList.AddAfter(linkedList.Head.Next.Next, 11);
            // 5 > 3 > 9 > (11) > 1 > 6 > 7
        }

        private static void SinglyLinkedList2()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(3);
            linkedList.AddFirst(5);
            // 5 > 3 > 1 => O(1)

            linkedList.AddLast(6);
            // 5 > 3 > 1 > 6
            linkedList.AddLast(7);
            // 5 > 3 > 1 > 6 > 7 => O(n)
        }

        private static void SinglyLinkedList1()
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
