using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WeekDay2
{
    internal class MyCollection
    {
        public static void InitList()
        {
            var alfabet = new List<string> { "A", "B", "C", "D", "E", };
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G", "H", "I" });
            alfabet.Insert(0, "J");
            alfabet.InsertRange(3, new[] { "X", "Y" });

            foreach (var item in alfabet)
            {
                Console.Write($" {item}");
            }



            var numbers = new List<int> { 2, 5, 7, 11, 13, 17, 19 };
            numbers.Add(23);


            //numbers.Remove(17);
            //numbers.RemoveAll(v => v >=7);
            Console.WriteLine();


            var a = numbers.Find(e => e < 10);
            var b = numbers.FindLast(e => e < 11);
            var c = numbers.FindAll(e => e > 10);

            var d = numbers.FindIndex(e => e <= 11);
            var e = numbers.FindLastIndex(e => e <= 11);
            var f = numbers.IndexOf(13);
            var g = numbers.BinarySearch(11);
            Console.WriteLine();


        }
        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] { 1, 2, 3 });
            numbers.Push(5);
            numbers.Push(7);


            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();

        }
        public static void InitDictionary()
        {
            var pl1 = new Dictionary<int, string>()
            {
                {1,"C" }, {2,"NodeJs"}, {3,"Python" }, {4,"Golang" }, {5,"Sql"}
            };
            pl1.Add(6, "JavaScript");
            pl1.Add(7, "C");
            pl1.Add(8, "C++");

            foreach (var item in pl1)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            Console.WriteLine();


        }
        public static void InitHashset()
        {
            HashSet<int> number = new HashSet<int>() { 1, 2, 3, 5, 8 };
            number.Add(5);
            number.Add(10);
            number.Add(8);

            var hs1 = new HashSet<int>() { 1, 2, 3, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var result1 = new HashSet<int>(hs1);

            result1.IntersectWith(hs2); //iner join 1,2

            var result2 = new HashSet<int>(hs1);
            result2.UnionWith(hs2); //union 1,2,3,4,5,6,9

            var result3 = new HashSet<int>(hs1);
            result3.ExceptWith(hs2); //5,6,9

            var result4 = new HashSet<int>(hs1);
            result4.SymmetricExceptWith(hs2); //3,4,5,6,9


            Console.WriteLine();
        }
        public static void InitQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Dios");
            queue.Enqueue("Widi");
            queue.Enqueue("Irham");

            Console.WriteLine($"Queue from front back");
            foreach (var item in queue)
            {

                Console.Write($"P{item}");
            }

            string served = queue.Dequeue();
            Console.WriteLine($"Served :{served}");

            Console.WriteLine($"Current Queue from front to back");
            foreach (var item in queue)
            {
                Console.Write($"{item}");
            }

            served = queue.Dequeue();
            Console.WriteLine($"served:{served}");

        }
        public static List<T> GetStudent<T>(ref List<T> list)
        {

            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }
            return myList;


        }
    }
}

