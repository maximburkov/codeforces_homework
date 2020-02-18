using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoContest
{
    static class Tasks_2
    {
        #region Task 1 zayavki
        //        using System;
        //using System.Linq;
        //using System.IO;

        //namespace AlgoContest
        //    {
        //        class Program
        //        {
        //            struct Request
        //            {
        //                public Request(char dir, int c, int v)
        //                {
        //                    Direction = dir;
        //                    Cost = c;
        //                    Volume = v;
        //                }

        //                public char Direction;
        //                public int Cost;
        //                public int Volume;
        //            }

        //            static void Main(string[] args)
        //            {
        //                int n;
        //                int s;
        //                Request[] a;

        //                //using (StreamReader r = new StreamReader("input.txt"))
        //                //{
        //                var buf = Console.ReadLine().Split().ToArray();
        //                //var buf = r.ReadLine().Split().ToArray();

        //                n = int.Parse(buf[0]);
        //                s = int.Parse(buf[1]);
        //                a = new Request[n];

        //                for (int i = 0; i < n; i++)
        //                {
        //                    buf = Console.ReadLine().Split().ToArray();
        //                    //buf = r.ReadLine().Split().ToArray();
        //                    a[i] = new Request(buf[0][0], int.Parse(buf[1]), int.Parse(buf[2]));
        //                }
        //                //}


        //                var res = a.GroupBy(i => new
        //                {
        //                    i.Direction,
        //                    i.Cost
        //                }).Select(i => new Request(i.Key.Direction, i.Key.Cost, i.Sum(j => j.Volume)));

        //                var sell = res.Where(i => i.Direction == 'S').OrderBy(i => i.Cost).Take(s).Reverse();
        //                var buy = res.Where(i => i.Direction == 'B').OrderByDescending(i => i.Cost).Take(s);

        //                res = sell.Union(buy);

        //                foreach (var item in res)
        //                {
        //                    Console.WriteLine($"{item.Direction} {item.Cost} {item.Volume}");
        //                }
        //            }
        //        }
        //    }
        #endregion

        #region Task 2 Reposts
        /*
         * using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace AlgoContest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, int>(n);
            dict.Add("POLYCARP", 1);

            for (int i = 0; i < n; i++)
            {
                var buf = Console.ReadLine().Split().ToArray();
                dict.Add(buf[0].ToUpper(), dict[buf[2].ToUpper()] + 1);
            }
            Console.WriteLine(dict.Max(i => i.Value));
        }
    }
}

         */
        #endregion

        #region Task 3 Dush
        //        using System;
        //using System.Linq;
        //using System.Collections.Generic;

        //namespace AlgoContest
        //    {
        //        class Program
        //        {
        //            static int GetHappy(int[,] arr, int fistIndex, int secondIndex) => arr[fistIndex, secondIndex] + arr[secondIndex, fistIndex];

        //            static int GetHappyForAll(int[,] arr, int[] pos) => GetHappy(arr, pos[0], pos[1]) + GetHappy(arr, pos[2], pos[3]) * 2
        //                + GetHappy(arr, pos[1], pos[2]) + GetHappy(arr, pos[3], pos[4]) * 2;

        //            static void GetMax(int[,] arr, ref int max, List<int> added, List<int> left)
        //            {
        //                if (added.Count == 5)
        //                {
        //                    int currentMax = GetHappyForAll(arr, added.ToArray());
        //                    if (currentMax > max)
        //                        max = currentMax;

        //                    return;
        //                }
        //                foreach (var item in left)
        //                {
        //                    var newAdded = added.ToList();
        //                    newAdded.Add(item);
        //                    var newLeft = left.ToList();
        //                    newLeft.Remove(item);
        //                    GetMax(arr, ref max, newAdded, newLeft);
        //                }
        //            }


        //            static void Main(string[] args)
        //            {
        //                int[,] arr = new int[5, 5];
        //                for (int i = 0; i < 5; i++)
        //                {
        //                    var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //                    for (int j = 0; j < 5; j++)
        //                    {
        //                        arr[i, j] = buf[j];
        //                    }
        //                }

        //                int max = 0;

        //                GetMax(arr, ref max, new List<int>(), new List<int> { 0, 1, 2, 3, 4 });
        //                Console.WriteLine(max);
        //            }
        //        }
        //    }
        #endregion

        #region Task 7 Security
        //using System;
        //using System.Linq;
        //using System.Collections.Generic;

        //namespace AlgoContest
        //{
        //    class Program
        //    {
        //        static void Main(string[] args)
        //        {
        //            int n = int.Parse(Console.ReadLine());
        //            int[,] res = new int[n, n];

        //            for (int i = 0; i < n; i++)
        //            {
        //                var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //                for (int j = 0; j < n; j++)
        //                {
        //                    if (i == 0 && j == 0)
        //                    {
        //                        res[i, j] = buf[j];
        //                    }
        //                    else
        //                    {
        //                        if (i == 0)
        //                        {
        //                            res[i, j] = res[i, j - 1] + buf[j];
        //                        }
        //                        else if (j == 0)
        //                        {
        //                            res[i, j] = res[i - 1, j] + buf[j];
        //                        }
        //                        else
        //                        {
        //                            res[i, j] = Math.Max(res[i - 1, j], res[i, j - 1]) + buf[j];
        //                        }
        //                    }
        //                }
        //            }

        //            Console.WriteLine(res[n - 1, n - 1]);
        //        }
        //    }
        //}
    #endregion

    #region Task 7 Fence
    //using System;
    //using System.Linq;
    //using System.Collections.Generic;

    //namespace AlgoContest
    //{
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
    //            int n = buf[0];
    //            int k = buf[1];

    //            int[] sum = new int[n];
    //            int[] f = Console.ReadLine().Split().Select(int.Parse).ToArray();

    //            sum[0] = f[0];

    //            for (int i = 1; i < k; i++)
    //            {
    //                sum[i] = sum[i - 1] + f[i];
    //            }

    //            int min = sum[k - 1];
    //            int minIndex = 1;

    //            for (int i = k; i < n; i++)
    //            {
    //                sum[i] = sum[i - 1] - f[i - k] + f[i];

    //                if (sum[i] < min)
    //                {
    //                    min = sum[i];
    //                    minIndex = i + 2 - k;
    //                }
    //            }

    //            Console.WriteLine(minIndex);

    //        }
    //    }
    //}
    #endregion
}
}
