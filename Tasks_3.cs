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

        #region Ilya and requests
        //        using System;
        //using System.Linq;

        //namespace AlgoContest
        //    {
        //        class Program
        //        {
        //            static void Main(string[] args)
        //            {
        //                var s = Console.ReadLine().ToCharArray();
        //                int n = int.Parse(Console.ReadLine());
        //                int[] arr = new int[s.Length];

        //                char prev = s[0];
        //                arr[0] = 1;

        //                for (int i = 1; i < s.Length; i++)
        //                {
        //                    arr[i] = s[i] == prev ? arr[i - 1] + 1 : arr[i - 1];
        //                    prev = s[i];
        //                }

        //                int left, right;
        //                for (int i = 0; i < n; i++)
        //                {
        //                    var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //                    left = buf[0] - 1;
        //                    right = buf[1] - 1;
        //                    Console.WriteLine(arr[right] - arr[left]);
        //                }
        //            }
        //        }
        //    }

        #endregion

        #region Chislo na doske
        //        using System;
        //using System.Linq;

        //namespace AlgoContest
        //    {
        //        class Program
        //        {
        //            static void Main(string[] args)
        //            {
        //                var k = int.Parse(Console.ReadLine());
        //                string s = Console.ReadLine();
        //                var arr = s.ToCharArray().Select(i => i - 48).ToArray();

        //                Array.Sort(arr);
        //                int sum = arr.Sum();

        //                int count = 0;
        //                int dif = k - sum;

        //                for (int i = 0; i < arr.Length; i++)
        //                {
        //                    if (dif > 0)
        //                    {
        //                        dif -= 9 - arr[i];
        //                        count++;
        //                    }
        //                    else
        //                        break;
        //                }

        //                Console.WriteLine(count);
        //            }
        //        }
        //    }
        #endregion

        #region Stroka
        //        using System;
        //using System.Linq;

        //namespace AlgoContest
        //    {
        //        class Program
        //        {
        //            static void Main(string[] args)
        //            {
        //                var s = Console.ReadLine().ToCharArray();
        //                var t = Console.ReadLine().ToCharArray();
        //                int length = s.Length;
        //                var map = new bool[length];

        //                int count = 0;
        //                for (int i = 0; i < length; i++)
        //                {
        //                    if (s[i] != t[i])
        //                    {
        //                        map[i] = true;
        //                        count++;
        //                    }
        //                }

        //                if (count % 2 == 0)
        //                {
        //                    int left = count / 2;

        //                    for (int i = 0; i < length; i++)
        //                    {
        //                        if (left == 0)
        //                            break;

        //                        if (map[i])
        //                        {
        //                            s[i] = s[i] == '0' ? '1' : '0';
        //                            left--;
        //                        }
        //                    }

        //                    Console.WriteLine(new string(s));
        //                }
        //                else
        //                {
        //                    Console.WriteLine("impossible");
        //                }
        //            }
        //        }
        //    }
        #endregion

        #region Raspil
//        using System;
//using System.Linq;

//namespace AlgoContest
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//                int n = buf[0];
//                int b = buf[1];

//                var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
//                var prices = new int[n / 2 - 1];

//                int odd = 0;
//                int even = 0;

//                for (int i = 0; i < n; i++)
//                {
//                    if (arr[i] % 2 == 0)
//                        odd++;
//                    else
//                        even++;

//                    if (i % 2 != 0) //if even
//                    {
//                        if (odd == even)
//                        {
//                            if (i != n - 1)
//                            {
//                                prices[(i + 1) / 2 - 1] = Math.Abs(arr[i + 1] - arr[i]);
//                            }
//                        }
//                        else
//                        {
//                            if (i != n - 1)
//                            {
//                                prices[(i + 1) / 2 - 1] = int.MaxValue;
//                            }
//                        }
//                    }
//                }

//                Array.Sort(prices);
//                int count = 0;

//                for (int i = 0; i < prices.Length; i++)
//                {
//                    b -= prices[i];

//                    if (b >= 0)
//                        count++;

//                    if (b <= 0)
//                        break;
//                }

//                Console.WriteLine(count);
//            }
//        }
//    }
    #endregion
}
}
