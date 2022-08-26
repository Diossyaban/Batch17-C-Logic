using System;

public class Soal2
{
    static public void Main()
    {
        DateTime now = DateTime.Now;
        Random rand = new Random((int)now.Millisecond);

        int[,] Nilai = new int[5, 10];
        for (int x = 0; x < Nilai.GetLength(0); ++x)
        {
            for (int y = 0; y < Nilai.GetLength(1); ++y)
            {
                Nilai[x, y] = 70 + rand.Next() % 31;
            }
        }
        int[] Average = new int[10];
        Console.WriteLine("Student Exam:\r\n");
        Console.WriteLine("     Perserta  1   2   3   4   5   6   7   8   9  10");
        Console.WriteLine("     -----------------------------------------------");

        for (int x = 0; x < Nilai.GetLength(0); ++x)
        {
            Console.Write("    Siswa " + (x + 1) + " ");
            for (int y = 0; y < Nilai.GetLength(1); ++y)
            {
                Average[y] += Nilai[x, y];
                Console.Write("{0,4:D}", Nilai[x, y]);
            }
            Console.WriteLine();
        }
        Console.Write("\r\nAvg Nilai.  ");
        foreach (int Avg in Average)
        {
            Console.Write("{0,4:D}", Avg / Nilai.GetLength(0));
        }
        Console.WriteLine();
    }
}