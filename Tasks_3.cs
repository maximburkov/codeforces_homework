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
}
}
