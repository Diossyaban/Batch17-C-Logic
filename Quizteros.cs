using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDay2
{
    internal class Quizteros
    {
        public static int findLongestConseqSubseq(int[] arr, int N)
        {

            List<int> pq = new List<int>();
            for (int i = 0; i < N; i++)
            {

 
                pq.Add(arr[i]);
                pq.Sort();
            }


            int prev = pq[0];

     
            int c = 1;


            int max = 1;

            for (int i = 1; i < N; i++)
            {

    
                if (pq[0] - prev > 1)
                {
   
                    c = 1;

         
                    prev = pq[0];
                    pq.RemoveAt(0);
                }


                else if (pq[0] - prev == 0)
                {

                
                    prev = pq[0];
                    pq.RemoveAt(0);
                }


                else
                {


                    c++;

   
                    prev = pq[0];
                    pq.RemoveAt(0);
                }

         
                if (max < c)
                {

          
                    max = c;
                }
            }

            return max;
        }

        // Driver Code
        public static void Main()
        {
            int[] arr = { 1, 1, 2, 3, 4, 1, 2,3 };
            int n = arr.Length;
            Console.WriteLine(
                "Length of the Longest consecutive subsequence is "
                + findLongestConseqSubseq(arr, n));
        }
    }

}

