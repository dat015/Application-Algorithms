using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap01
{
    public class bai28
    {
        public static int Rank(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid]) hi = mid - 1;
                else if (key > a[mid]) lo = mid + 1;
                else return mid;
            }
            return -1;
        }

        public static void run28()
        {
            int[] whitelist = { 5, 1, 2, 2, 5, 7, 8, 1, 3 };

            Array.Sort(whitelist);
            Console.WriteLine("Whitelist before removing duplicates: " + string.Join(", ", whitelist));

            whitelist = whitelist.Distinct().ToArray();
            Console.WriteLine("Whitelist after removing duplicates: " + string.Join(", ", whitelist));

            int key = 7;
            int result = Rank(key, whitelist);
            if (result < 0)
                Console.WriteLine(key + " is not in the whitelist");
            else
                Console.WriteLine(key + " is in the whitelist at index " + result);
        }
    }
}
