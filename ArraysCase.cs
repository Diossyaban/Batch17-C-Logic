
using System.Diagnostics;

namespace WeekDay2
{
    internal class ArraysCase
    {

        public static void IntroArray()
        {
            //declare array with int data
            int[] arr;
            int[] arrInt = new int[5];
            arrInt[0] = 12;
            arrInt[1] = 45;
            arrInt[3] = 50;
            arrInt[4] = 1_000_000;
            //arrInt[6] = 90;

            //int array with string data

            string[] listOfGirl = new string[] { "yuli", "widi", "yuli" };

            //display array

            foreach (var item in listOfGirl)
            {
                Console.WriteLine($"{item}");
            }


            for (int i = 0; i < listOfGirl.Length; i++)
            {
                Console.WriteLine(listOfGirl[i]);
            }

        }
        public static int[] InitArrayInt(int[] arr) //Method return of function input array int, return array int
        {
            int[] array = arr;
            return array;
        }
        public static int[] InitArrayRandom(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50);
            }


            return arr;
        }
        public static double SumAllElement(int[] arr) //sum all array element
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum +=arr[i];
            }
          
            return sum;
        }
        public static int FindLargestElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr) 
            {
                Console.Write($" {item} ");
            }
        }
        

    }
}
