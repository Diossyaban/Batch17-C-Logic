using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace WeekDay2
{

    internal class Matrix
    {
        public static void InitMatrix()
        {
            int[,] matrix = new int[5, 5];
            matrix[2, 2] = 125;
            // Console.WriteLine(matrix);
        }
        public static int[,] FillRandomMatrix(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++) // i = baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)// j= kolom
                {
                    matrix[i, j] = random.Next(20);
                }
            }

            return matrix;
        }
        public static int[,] MatrixDiagonal(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = 0;

            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = counter++;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
        }
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//loop kolom
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public static void DisplayArrayInteger(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
        }

        public static void Soal1()
        {
            int[] array = { 15, 2, 30, 12, 10, 5 };
           
            Random rand = new Random();
            Console.WriteLine("Sebelum random ");
            DisplayArrayInteger(array);
            Console.WriteLine("\n");
            for (int i = 0; i < array.Length; i++)
            {
                int randomIndex = rand.Next(0, array.Length); 
              
                int temp = array[randomIndex];
                array[randomIndex] = array[i];
              
                array[i] = temp;
             
            }
            Console.WriteLine("After random position ");
            DisplayArrayInteger(array);
        }
        public static void Soal7()
        {
            int[] arr = { 1, 2, 3, 2, 7, 7, 1, 6, 3, 4, 5, 2, 3, 6, 8, 9 };
            Console.WriteLine("Before remove ");
            DisplayArrayInteger(arr);

            int[] arr2 = arr.Distinct().ToArray();

            Console.WriteLine("\nAfter remove duplicate ");
            Array.Sort(arr2);
            DisplayArrayInteger(arr2);

        }

        public static int[,] Soal10(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random rand = new Random();
            double sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(100);
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                    else if (i < j)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }

                }

            }

            Console.WriteLine($"Total Hasil Sum diagonal : {sum}");

            return matrix;

        }

        public static int[,] Soal11(int baris, int kolom)
        {
            int[,] array = new int[baris, kolom];
            int n = baris - 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i + j;
                    if (i != 0 && j != 0)
                    {
                        if (i != n && j != n)
                        {
                            array[i, j] = 0;
                        }
                    }
                }
            }
            return array;

        }
    }
}

