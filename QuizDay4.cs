using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDay2
{
    internal class QuizDay4
    {
        public static void Soal5()
        {
            var array1 = new List<string> { "Mangga", "Apel", "Melon", "Pisang", "Sirsak", "Tomat", "Nanas", "Nangka", "Timun", "Mangga" };
            var array2 = new List<string> { "Bayam", "Wortel", "Kangkung", "Mangga", "Tomat", "Kembang Kol", "Nangka", "Timun" };

            var sama = new List<string>();
            var beda = new List<string>();

            for (int i = 0; i < array1.Count; i++)
            {
                if (array2.Contains(array1[i]))
                {
                    if (!sama.Contains(array1[i]))
                    {
                        sama.Add(array1[i]);
                    }
                }
                else
                {
                    beda.Add(array1[i]);
                }
            }
            for (int j = 0; j < array2.Count; j++)
            {
                if (!array1.Contains(array2[j]))
                {
                    if (!beda.Contains(array2[j]))
                    {
                        beda.Add(array2[j]);
                    }
                }

            }
            Console.WriteLine(" Buah 1 = Mangga Apel Melon Pisang Sirsak Tomat Nanas Nangka Timun Mangga");
            Console.WriteLine(" Buah 2 =Bayam Wortel Kangkung Mangga Tomat Kembang Kol Nangka Timun");
            Console.Write("Kata yang sama = ");
            Display(sama );
            Console.Write("\nKata yang berbeda = ");
            Display(beda);
        }

        public static void Display(List<string> x)
        {
            foreach (var i in x)
            {
                Console.Write(i + " ");
            }
        }
    }
}
