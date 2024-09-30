using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap01
{
    public class bai31
    {
        public static void run31()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int N = 5;  
            double p = 0.3;  

            double[] x = new double[N];
            double[] y = new double[N];
            double angleIncrement = 2 * Math.PI / N;

            for (int i = 0; i < N; i++)
            {
                x[i] = Math.Cos(i * angleIncrement);  
                y[i] = Math.Sin(i * angleIncrement);  
                Console.WriteLine($"Điểm {i + 1}: ({x[i]:F2}, {y[i]:F2})");  
            }

            Random rand = new Random();
            Console.WriteLine("\nKết nối các điểm với xác suất p:");

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    double randomValue = rand.NextDouble();
                    if (randomValue <= p)
                    {
                        Console.WriteLine($"Kết nối Điểm {i + 1} với Điểm {j + 1} (giá trị ngẫu nhiên: {randomValue:F2})");
                    }
                }
            }
        }

       
    }
}
