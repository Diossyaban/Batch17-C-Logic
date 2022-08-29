using System;

namespace WeekDay2
{
    internal class Quiz4
    {
        static void Main(string[] args)
        {
            String str1;
            str1 = "11234123";
            Console.WriteLine("Original String: " + str1);
            Console.WriteLine("Setelah Duplikat:");
            Console.WriteLine(remove_duplicate_chars(str1));
            str1 = "7531";
            Console.WriteLine("Original String: " + str1);
            Console.WriteLine("Setelah Duplikat:");
            Console.WriteLine(remove_duplicate_chars(str1));
            str1 = "111111";
            Console.WriteLine("Original String: " + str1);
            Console.WriteLine("Setelah Duplikat:");
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

