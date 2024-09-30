using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Baitap01 
{
    public class bai32
    {
        public static void run32()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int N = 5;  // Số lượng khoảng
            double l = 0.0;  // Giới hạn dưới
            double r = 10.0;  // Giới hạn trên
            List<double> values = new List<double> { 1.2, 2.3, 3.4, 4.5, 5.6, 6.7, 8.1, 9.2, 10.0 };

            if (l >= r)
            {
                Console.WriteLine($"Giới hạn dưới phải nhỏ hơn giới hạn trên.");
                return;
            }

            double intervalWidth = (r - l) / N;
            int[] counts = new int[N];

            foreach (double value in values)
            {
                if (value >= l && value < r)
                {
                    int index = (int)((value - l) / intervalWidth);
                    if (index >= 0 && index < N)
                    {
                        counts[index]++;
                    }
                }
            }

            Console.WriteLine($"Histogram cho {N} khoảng từ {l} đến {r}:");
            for (int i = 0; i < N; i++)
            {
                double intervalStart = l + i * intervalWidth;
                double intervalEnd = intervalStart + intervalWidth;
                Console.WriteLine($"Khoảng [{intervalStart:F2}, {intervalEnd:F2}): {counts[i]} giá trị");
            }
        }
    }
   

    
}
