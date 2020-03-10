using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AlgoContest
{
    class Tasks_3
    {
        #region Gidro
        //using System;
        //using System.Linq;

        //namespace AlgoContest
        //{
        //    class Program
        //    {
        //        static void Main(string[] args)
        //        {
        //            int n = int.Parse(Console.ReadLine());
        //            int max = 0;
        //            bool isPrevSunny = false;
        //            int count = 0;
        //            var days = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //            for (int i = 0; i < n; i++)
        //            {
        //                int t = days[i];

        //                if (t < 0 && t % 2 == 0)
        //                {
        //                    if (isPrevSunny)
        //                    {
        //                        count++;
        //                    }
        //                    else
        //                    {
        //                        count = 1;
        //                        isPrevSunny = true;
        //                    }
        //                }
        //                else
        //                {
        //                    if (isPrevSunny)
        //                    {
        //                        if (count > max)
        //                            max = count;
        //                    }

        //                    count = 0;
        //                }

        //                if (i == n - 1)
        //                {
        //                    if (isPrevSunny)
        //                    {
        //                        if (count > max)
        //                            max = count;
        //                    }
        //                }
        //            }

        //            Console.WriteLine(max);
        //        }
        //    }
        //}

        #endregion

        #region Natasha
        //        using System;
        //        using System.Linq;

        //        namespace AlgoContest
        //        {

        //    class Program
        //    {
        //        static void Main(string[] args)
        //        {
        //            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //            int n = buf[0];
        //            int m = buf[1];

        //            var arr = new int[n][];

        //            for (int i = 0; i < n; i++)
        //            {
        //                arr[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //            }

        //            int res = arr.OrderBy(i => i.Min()).Last().Min();
        //            Console.WriteLine(res);
        //        }
        //    }
        //}
        #endregion

        #region Tickets
        //using System;
        //using System.Linq;

        //namespace AlgoContest
        //{
        //    class Program
        //    {

        //        static void Main(string[] args)
        //        {
        //            int n = int.Parse(Console.ReadLine());
        //            var buf = Console.ReadLine().ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
        //            var head = buf.Take(n).ToArray();
        //            var tail = buf.Skip(n).ToArray();

        //            Array.Sort(head);
        //            Array.Sort(tail);

        //            bool allLess = true;
        //            bool allBigger = true;

        //            for (int i = 0; i < n; i++)
        //            {
        //                if (head[i] >= tail[i])
        //                    allLess = false;

        //                if (head[i] <= tail[i])
        //                    allBigger = false;
        //            }

        //            Console.WriteLine(allBigger || allLess ? "YES" : "NO");
        //        }
        //    }
        //}
        #endregion 

        #region partitions
//        using System;
//        using System.Linq;

//        namespace AlgoContest
//        {
//            class Program
//            {
//        private static int _count = 0;

//        static void Solve(int sum, int max)
//        {
//            if (sum == 0)
//            {
//                _count++;
//                return;
//            }
//            for (int i = max; i >= 1; i--)
//            {
//                if (i <= sum)
//                {
//                    Solve(sum - i, i);
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int n = buf[0];
//            int m = buf[1];

//            Solve(n, m);

//            Console.WriteLine(_count);
//        }
//    }
//}
    #endregion 

}
}
