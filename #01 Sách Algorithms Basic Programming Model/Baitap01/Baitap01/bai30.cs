using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap01
{
    public class bai30
    {
        public static int GCD(int i, int j)
        {
            while (j != 0)
            {
                int temp = j;
                j = i % j;
                i = temp;
            }
            return i;
        }
        public static void run30()
        {
            int N = 10; 
            bool[,] a = new bool[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    a[i, j] = (GCD(i, j) == 1);
                }
            }

            Console.WriteLine("Boolean array showing relatively prime pairs (true = relatively prime):");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(a[i, j] ? "T " : "F ");
                }
                Console.WriteLine();
            }
        }
    }
}
