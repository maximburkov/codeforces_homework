using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AlgoContest
{
    class Program
    {
        static int BinarySearchCount(int[] a, int find, int l, int r)
        {
            if (l == r)
            {
                return a[l] > find ? l : l + 1;
            }

            int m = (l + r) / 2;

            if (a[m] > find && (m == 0 || a[m - 1] <= find))
                return m;

            if(a[m] <= find)
                return BinarySearchCount(a, find, m + 1, r);
            else
                return BinarySearchCount(a, find, l, m - 1);
        }


        static void Main(string[] args)
        {
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = buf[0];
            int m = buf[1];

            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var b = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(a);

            for (int i = 0; i < m; i++)
            {
                var count = BinarySearchCount(a, b[i], 0, n - 1);
                Console.WriteLine(count);
            }
        }
    }
}
