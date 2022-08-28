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
            queue.Enqueue("Nada");
            queue.Enqueue("Syarifa");

            Console.WriteLine($"Queue from front back");
            foreach (var item in queue)
            {

                Console.Write($"{item}");
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

        public static void SoalFindLongestSequence()
        {
            HashSet<int> number = new HashSet<int>() { 7, 2, 7, 1, 2,5,1 };
            
         

            var hs1 = new HashSet<int>() { 7, 2, 7, 1, 2, 3, 8, 1, 2, 3, 4, 5 };
            var hs2 = new HashSet<int>() { 1, 1, 2, 2, 2, 3, 3, 3, 3 } ;
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

        static int[,] dp = new int[1000, 1000];

      
        public static int findLongestRepeatingSubSeq(char[] X, int m, int n)
        {

            if (dp[m, n] != -1)
            {
                return dp[m, n];
            }

          
            if (m == 0 || n == 0)
            {
                return dp[m, n] = 0;
            }

      
            if (X[m - 1] == X[n - 1] && m != n)
            {
                return dp[m, n] = findLongestRepeatingSubSeq(X,
                        m - 1, n - 1) + 1;
            }

        
            return dp[m, n] = Math.Max(findLongestRepeatingSubSeq(X, m, n - 1),
                    findLongestRepeatingSubSeq(X, m - 1, n));
        }

    
        static public void Main()
        {
            Console.WriteLine("1234443324");
            String str = "1234443324";
            int m = str.Length;
            for (int i = 0; i < dp.GetLength(0); i++)
                for (int j = 0; j < dp.GetLength(1); j++)
                    dp[i, j] = -1;
            Console.WriteLine("The length of the largest subsequence that"
                    + " repeats itself is : "
                    + findLongestRepeatingSubSeq(str.ToCharArray(), m, m));

        }

        static void Main(string[] args)
        {
            String str1;
            str1 = "aaaaaabbbbccc";
            Console.WriteLine("Original String: " + str1);
            Console.WriteLine("After removing duplicates characters from the said string:");
            Console.WriteLine(remove_duplicate_chars(str1));
            str1 = "Python";
            Console.WriteLine("Original String: " + str1);
            Console.WriteLine("After removing duplicates characters from the said string:");
            Console.WriteLine(remove_duplicate_chars(str1));
            str1 = "Java";
            Console.WriteLine("Original String: " + str1);
            Console.WriteLine("After removing duplicates characters from the said string:");
            Console.WriteLine(remove_duplicate_chars(str1));
        }

        public static string remove_duplicate_chars(string str1)
        {
            var indexes = new Dictionary<char, int>();
            for (int i = 0; i < str1.Length; i++)
                indexes[str1[i]] = i;

            var flag = new HashSet<char>();
            var stack = new Stack<char>();
            for (int i = 0; i < str1.Length; i++)
            {
                var ele = str1[i];
                if (!flag.Contains(ele))
                {
                    while (stack.Count > 0 && stack.Peek() > ele && i < indexes[stack.Peek()])
                        flag.Remove(stack.Pop());

                    flag.Add(ele);
                    stack.Push(ele);
                }
            }

            var s = new char[stack.Count];
            int index = stack.Count - 1;
            foreach (var ele in stack)
                s[index--] = ele;
            return new string(s);
        }
    }
}
    






