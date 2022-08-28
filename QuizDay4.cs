using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDay2
{
    internal class QuizDay4
    {
        public static void RemoveDuplicate()
        {

            HashSet<int> number = new HashSet<int>(5);
            var numbers = new List<int> { 1, 1, 2, 3, 4, 1, 2,3 };
            var numbers1 = new List<int> { 7, 5, 3, 5, 1 };
            var number2 = new List<int> { 1, 1, 1, 1, 1, 1 };

            Console.WriteLine("Input");

            foreach (int a in numbers)
                Console.WriteLine(a);
            
            
        }
    }
}
