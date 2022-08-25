using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace WeekDay1
{
    internal class Week2Quiz
                    {
                        public static void Soalnomor1()
                        {
                            int sum = 0;
                            Console.Write("MASUKKE NUMBER INTEGER !!!: ");
                            int number = Convert.ToInt32(Console.ReadLine());

                            while (number > 0)

                            {
                                sum += (number % 10);
                                number /= 10;
                            }
                            Console.Write($" TOTAL SUMNYA ADALAHHH :{sum}");

                        }
                        public static void Soalnomor2()
                        {
                            int count = 0;
                            Console.Write("AYO BESTIE MASUKKE NUMBER INTEGER !!!: ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            int digit = 0;
                            while (number > 0)
                            {
                                count += (number % 10);
                                number /= 10;
                                digit++;
                            }
                            Console.Write($" Count :{digit}");

                        }
                        public static void Soalnomor3()
                        {
                            int Hasil = 0;
                            Console.Write("MASUKKE NUMBER INTEGER !!!: ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            while (number > 0)
                            {
                                Hasil = (number % 10);
                                number /= 10;
                                Console.Write($" {Hasil}");


                            }

                        }
                        public static void Soalnomor4()
                        {
                            int max = 0;
                            Console.Write("Ayo Masukkan Angka Terbesar LOOP:");
                            int number = Convert.ToInt32(Console.ReadLine());

                            for (int i = 1; i < number; i++)
                            {
                                max++;
                            }
                            Console.WriteLine($"Angka ke-2 Terbersar : {max}");
                        }
                        public static void Soalnomor5()

                        {
                            Console.WriteLine("Ayok kita tebak-tebakan pilih nomor 0 sampai 20 :");

                            Random random = new Random();
                            int number = random.Next(0, 20);

                            int guess = -1;
                            while (guess != number)
                            {
                                Console.Write("Ayo pilih yang mana?");
                                var input = Console.ReadLine();
                                int.TryParse(input, out guess);

                                //cek kondisi

                                if (guess == number)
                                {
                                    Console.WriteLine($"yah Sensasional selamat, nomor : {guess}");
                                    Console.Write("PILIH LAGI :");
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    if (key.Key == ConsoleKey.Y)
                                    {
                                        Console.WriteLine();
                                        Soalnomor5();
                                    }
                                    else if (key.Key == ConsoleKey.N)
                                    {
                                        Console.WriteLine("Quit");
                                        break;
                                    }
                                }
                                else if (guess > number)
                                {
                                    Console.WriteLine("yah nomornya salah. yah belom berhasil!");
                                }
                            }
                        }
                        public static void Soalnomor6()
                        {
                            int max = 0;
                            int number = 0;

                            for (int i = 0; i >= number; i++)
                            {
                                Console.Write("Masukkan Angkanya ges [type 0 for exit] : ");
                                int angka = Convert.ToInt32(Console.ReadLine());
                                if (angka > max)
                                {
                                    max = angka;

                                }
                                else if (number == 0)
                                {
                                    Console.Write($"{max}");
                                    break;
                                }

                            }
                        }
                        public static void Soalnomor7()

                        {
                            Console.Write("Masukan Nomornya bestie :");
                            int number = Convert.ToInt32(Console.ReadLine());

                            for (int i = 1; i <= number; i++)
                            {
                                if (number % i == 0)
                                {
                                    Console.WriteLine(i + "");
                                }

                            }
                        }
                        public static void Soalnomor8()
                        {
                            Console.Write("Enter Limit Number : ");
                            int number = Convert.ToInt32(Console.ReadLine());

                            for (int i = 2; i <= number; i++)
                            {
                                int jumlah = 0;
                                for (int j = 1; j <= i; j++)
                                {
                                    if (i % j == 0)
                                    {
                                        jumlah++;
                                    }
                                }
                                if (jumlah == 2)
                                {
                                    Console.Write(i + " ");
                                }
                            }


                        }
                        public static void Soalnomor9()
                        {
                            Console.Write("Masukkan strings  : ");
                            string name = Console.ReadLine();
                            string widi=name.ToLower();
                            string reverse = string.Empty;

                            for (int i = widi.Length - 1; i >= 0; i--)
                            {
                                reverse += widi[i];
                            }

                            if (widi == reverse)
                            {
                                Console.WriteLine($"{widi} yes ini merupakan palindrome.");
                            }
                            else
                            {
                                Console.WriteLine($"{widi} ini bukan palindrome");
                            }
                            Console.ReadKey();
                        }
                        public static void Soalnomor10()
                       
                        { 
                            int vokal = 0;
                            int konsonan = 0;
                            Console.Write("Enter Strings : ");
                            string kata = Convert.ToString(Console.ReadLine());
                            string kalimat = "";

                            for (int i = 0; i < kata.Length; i++)
                            {
                                kalimat = kata[i].ToString();
                                if (kalimat == "a" || kalimat == "i" || kalimat == "u" || kalimat == "e" || kalimat == "o")
                                {
                                    vokal++;
                                }
                                else
                                {
                                    konsonan++;
                                }
                            }

                            Console.WriteLine($" huruf Vokal : {vokal}");
                            Console.WriteLine($" huruf konsonan : {konsonan}");


                        }
                        public static void Soalnomor11()
                        {
            
                                Console.Write("Enter Strings : ");
                                string kata = Convert.ToString(Console.ReadLine());
                                string spasi = "";
                                int count = 1;

                                for (int i = 0; i < kata.Length; i++)
                                {
                                    spasi = kata[i].ToString();
                                    if (spasi == " ")
                                    {
                                        count++;
                                    }
                                }
                                Console.Write($"Total kata : {count}");
                            }
                        public static void Soalnomor12()
                        {
                            Console.Write("Masukkan Strings");
                        }
                        public static void Soalnomor13()
                        {
                            Console.Write("Masukkan Strings");
                        }
                        public static void Soalnomor14()
                        {
                            Console.Write("Masukkan Strings");

                        }
                        public static void Soalnomor15()
                        {
                            Console.Write("Enter Number 1");

                        }

        

    }
}




  


        

    



 