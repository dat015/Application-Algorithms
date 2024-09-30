using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap01
{
    public class clientTest_33
    {
        public static void run33()
        {
            double[] x = { 1.0, 2.0 }; // Kích thước 2
            double[] y = { 4.0, 5.0, 6.0 }; // Kích thước 3, sẽ gây lỗi nếu gọi phương thức dot với x

            double[][] a = {
            new double[] { 1.0, 2.0 }, // Kích thước 1x2
            new double[] { 3.0, 4.0 }, // Kích thước 1x2
            new double[] { 5.0, 6.0 }  // Kích thước 1x2
        };

            double[][] b = {
            new double[] { 7.0, 8.0 }, // Kích thước 1x2
            new double[] { 9.0, 10.0 } // Kích thước 1x2
        };

            // Kiểm tra các phương thức
            Console.WriteLine("Tích vô hướng của x và y: " + bai33.dot(x, new double[] { 1.0, 2.0 })); // Xem xét lại kích thước
            double[][] productMatrix = bai33.mult(a, b);
            Console.WriteLine("Tích của ma trận a và b:");
            for (int i = 0; i < productMatrix.Length; i++)
            {
                Console.WriteLine(string.Join(", ", productMatrix[i]));
            }

            double[][] transposed = bai33.transpose(a);
            Console.WriteLine("Ma trận chuyển vị của a:");
            for (int i = 0; i < transposed.Length; i++)
            {
                Console.WriteLine(string.Join(", ", transposed[i]));
            }

            // Sử dụng vector kích thước 2 cho ma trận kích thước 3x2
            double[] vectorProduct = bai33.mult(a, x);
            Console.WriteLine("Tích của ma trận a và vector x: " + string.Join(", ", vectorProduct));

            // Sử dụng vector kích thước 3 cho ma trận kích thước 3x2
            double[] vectorMatrixProduct = bai33.mult(y.Take(2).ToArray(), a); // Chỉ lấy 2 phần tử đầu
            Console.WriteLine("Tích của vector y và ma trận a: " + string.Join(", ", vectorMatrixProduct));
        }
    }
}
