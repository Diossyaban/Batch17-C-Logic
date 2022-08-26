using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDay2
{
    internal class ArrayTest
    {
        //Soal No.1
        //Buat program untuk menampilkan array dimana position index-nya bisa diacak (random)
        public static int[] InitArrayInt(int[] arr)
        {
            int[] array = arr;
            return array;
        }

        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        //bilangan Random
        public static int[] ArrayRandom(int[] n)
        {
            int[] arr = n;
            Random rand = new Random();

            for (int i = 0; i < n.Length; i++)
            {
                int var = arr[i];
                int j = rand.Next(0, n.Length);
                arr[i] = arr[j];
                arr[j] = var;
            }

            return arr;
        }


        //Soal No.2
        //program untuk menggeser element pertama ke element terakhir, dan menggeser
        //element kedua sampai element terakhir maju ke depan

        public static int[] Shifting(int[] n)
        {
            int[] arr = n;
            for (int i = 0; i < n.Length; i++)
            {
                if (i < n.Length - 1)
                {
                    arr[i] = n[i + 1];
                }
                else
                {
                    arr[i] = n[0];
                }
            }
            return arr;
        }

        //Soal No.3
        //Masih seperti kasus nomor 2, sekarang buat program untuk rotasi array ke kiri sebanyak n

        public static int[] ShiftingTerus(int[] n)
        {
            int[] arr = n;
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    int var = (i + j) % n.Length;
                    int nilai = arr[i];

                    Console.Write(nilai);
                    Console.WriteLine("");

                }
                Console.WriteLine();


            }
            return arr;

        }
    }
}


    

    

