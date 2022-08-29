
namespace WeekDay2
{
    internal class QuizMatrix
    {
        public static void DuplicateElement(string[] args)
        {

            int n, i, j, x;
            int[] arr = new int[55];
            Console.WriteLine("Masukkan Array  :");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukkan Array Elements  :");
            for (i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Original Arrays :");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Setelah di hapus yang sama: ");
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n;)
                {
                    if (arr[i] == arr[j])
                    {
                        for (x = j; x < n; x++)
                        {
                            arr[x] = arr[x + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++;
                    }
                }

            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }



        }
    }
}
    