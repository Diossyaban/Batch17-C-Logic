


using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Week2Day1
{
    internal class MathCase

    {
        //** 
        //
        //
        public static void ATM()
        {
            int digit1, digit2, digit3, sisa;
            Console.Write("Enter Money:");
            int number = Convert.ToInt32(Console.ReadLine());
            digit1 = number / 50_000;
            sisa = number % 50_000;

            digit2 = number / 10_000;
            sisa = number % 10_000;

            digit3 = number / 5_000;
            sisa = number % 5_000;
            Console.WriteLine($"Rp50Ribu={digit1} Rp10ribu={digit2} Rp.5ribu= {digit3} sisa={sisa}");


        }
        //** input bilangan :2345 *Ouput :2+3+4+5=15
        public static void SumDigit()
        {
            int digit1, digit2, digit3, r;
            Console.WriteLine(" Enter 4 digit number :");
            int number = Convert.ToInt32(Console.ReadLine());

            digit1 = number / 1000;
            r = number % 1000;

            digit2 = r / 100;
            r = r % 100;

            digit3 = r / 10;
            r = r % 10;

            int sum = digit1 + digit2 + digit3 + r;
            Console.WriteLine("Total Sum :" + sum);


        }
        /// <summary>
        /// /// REVERSEE
        /// </summary>
        public static void ReverseDigit()
        {
            int r, digit3, digit2, digit1;
            Console.WriteLine(" Enter 4 digit number :");
            int number = Convert.ToInt32(Console.ReadLine());

            digit1 = number / 1000;
            r = number % 1000;

            digit2 = r / 100;
            r = r % 100;

            digit3 = r / 10;
            r = r % 10;

            string reverse = r + ""+digit3 + "" + digit2 + "" + digit1;
            Console.WriteLine("Total Reverese :" + reverse);
            Console.WriteLine("Reverse;" + reverse);


        }

        // Fizzbuzz

        public static void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");

                }
                else
                    Console.WriteLine(i);

            }


        }

        public static bool isPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {

                    return false;
                }

                }
                return true;
            }

        }
    }
