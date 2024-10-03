using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Baitap02
{
    internal class bai15
    {
        public static int[] ReadInts(string fileName)
        {
            try
            {
                string input = File.ReadAllText(fileName);

                string[] words = input.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                int[] ints = new int[words.Length];

                for (int i = 0; i < words.Length; i++)
                {
                    ints[i] = int.Parse(words[i]);
                }

                return ints;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Không tìm thấy tệp: " + fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }

            return new int[0]; 
        }

        public static void run15()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string fileName = "numbers.txt";

            int[] numbers = ReadInts(fileName);

            if (numbers.Length > 0)
            {
                Console.WriteLine("Các số đã đọc từ tệp:");
                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
            }
            else
            {
                Console.WriteLine("Không có số nào được đọc từ tệp.");
            }
        }

    }
}
