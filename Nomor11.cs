

namespace Week2Day1
{
    internal class Week2Day1
    {
      public static void Soal11(string[] args)
        {
            string kalimat;
            int vokal = 0, konsonan = 0, angka = 0, spasi = 0, spesial = 0;
            string kal = "aieuoAIEUO";
            Console.Write("input Suatu kalimat= ");
            kalimat = Console.ReadLine();
            for (int i = 0; i < kalimat.Length; i++)
            {
                if (char.IsLetter(kalimat[i]))
                {
                    if (kal.Contains(kalimat[i]))
                    {
                        vokal += 1;
                    }
                    else
                    {
                        konsonan += 1;
                    }
                }
                else if (char.IsNumber(kalimat[i]))
                {
                    angka += 1;
                }
                else if (char.IsWhiteSpace(kalimat[i]))
                {
                    spasi += 1;
                }
                else if (char.IsPunctuation(kalimat[i]))
                {
                    spesial += 1;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Jumlah Vokal    ={0}", vokal);
            Console.WriteLine("Jumlah konsonan ={0}", konsonan);
            Console.WriteLine("Jumlah Angka    ={0}", angka);
            Console.WriteLine("Jumlah spasi    ={0}", spasi);
            Console.WriteLine("Jumlah Spesial  ={0}", spesial);
            Console.ReadKey();
        }
    }
}