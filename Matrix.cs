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
        public static int[,] SumMatriks(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int sum = 0;
            int sum2 = 0;
            int n = baris - 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i != n && j != n)
                    {
                        matrix[i, j] = i + j;
                        if (j <= n)
                        {
                            sum += matrix[i, j];
                            matrix[n, i] = matrix[i, n] = sum;

                            if (i == j)
                            {
                                sum2 += matrix[i, j];
                                matrix[n, n] = sum2;
                            }

                            if (j == n - 1)
                            {
                                sum = 0;
                            }
                        }
                    }
                }
            }

            return matrix;
        }
    }
}


