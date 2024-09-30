using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap01
{
    public class bai29
    {
        public static int Rank(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key > a[mid]) lo = mid + 1;
                else hi = mid - 1;
            }
            return lo;
        }

        public static int Count(int key, int[] a)
        {
            int first = FirstOccurrence(key, a);
            if (first == -1) return 0;

            int last = LastOccurrence(key, a);
            return last - first + 1;
        }
        private static int FirstOccurrence(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;
            int result = -1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (a[mid] == key)
                {
                    result = mid;
                    hi = mid - 1;
                }
                else if (key < a[mid])
                    hi = mid - 1;
                else
                    lo = mid + 1;
            }
            return result;
        }

        private static int LastOccurrence(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;
            int result = -1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (a[mid] == key)
                {
                    result = mid;
                    lo = mid + 1;
                }
                else if (key < a[mid])
                    hi = mid - 1;
                else
                    lo = mid + 1;
            }
            return result;
        }

        public static void run29()
        {
            int[] whitelist = { 1, 2, 2, 2, 3, 4, 5, 5, 6, 7 };

            int key = 2;

            int rank = Rank(key, whitelist);
            Console.WriteLine("Number of elements smaller than " + key + ": " + rank);

            int count = Count(key, whitelist);
            Console.WriteLine("Number of elements equal to " + key + ": " + count);

            if (count > 0)
            {
                Console.WriteLine("Elements equal to " + key + ":");
                for (int i = rank; i < rank + count; i++)
                {
                    Console.WriteLine(whitelist[i]);
                }
            }
        }

    }
}
