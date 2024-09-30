using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap01
{
    public class bai34
    {
        public static void run34()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Print the maximum and minimum numbers: ");
            Console.WriteLine("Có thể thực hiện bằng bộ lọc:  chỉ cần giữ lại hai biến cho giá trị tối đa và tối thiểu.");

            Console.WriteLine("Print the median of the numbers: ");
            Console.WriteLine("Cần lưu tất cả giá trị: Median yêu cầu sắp xếp các giá trị để xác định giá trị giữa. Cần lưu tất cả các số vào một mảng.");

            Console.WriteLine("Print the k th smallest value, for k less than 100: ");
            Console.WriteLine("Có thể thực hiện bằng bộ lọc: Nếu k luôn nhỏ hơn 100, có thể duy trì một mảng cố định có kích thước 100 để theo dõi các số nhỏ nhất.");

            Console.WriteLine("Print the sum of the squares of the numbers: ");
            Console.WriteLine("Có thể thực hiện bằng bộ lọc: Chỉ cần một biến để lưu tổng bình phương, không cần lưu tất cả các số.");

            Console.WriteLine("Print the average of the N numbers: ");
            Console.WriteLine("Có thể thực hiện bằng bộ lọc: Chỉ cần giữ tổng và đếm số lượng số để tính trung bình.");

            Console.WriteLine("Print the percentage of numbers greater than the average: ");
            Console.WriteLine("Cần lưu tất cả giá trị: Cần tính trung bình trước, vì vậy cần lưu tất cả các số để so sánh.");

            Console.WriteLine("Print the N numbers in increasing order: ");
            Console.WriteLine("Cần lưu tất cả giá trị: Cần một mảng để sắp xếp các giá trị.");

            Console.WriteLine("Print the N numbers in random order: ");
            Console.WriteLine("Cần lưu tất cả giá trị: Cần lưu tất cả các số trong một mảng để có thể trộn chúng một cách ngẫu nhiên.");
        }
    }
}
