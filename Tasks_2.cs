using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        #region Task 4 Sahir Ohrannik

        //        using System;
        //using System.Linq;

        //namespace AlgoContest
        //    {
        //        class Program
        //        {
        //            private static int ColCount;
        //            private static int FloorCount;
        //            private static int[] LastsFromLeft;
        //            private static int[] LastsFromRight;
        //            private static int LastFloor = 0;

        //            static int GetDistance(bool isLeft, int floor, int total)
        //            {
        //                if (floor == LastFloor)
        //                {
        //                    var res = total + (isLeft ? LastsFromLeft[floor] : LastsFromRight[floor]);
        //                    return res;
        //                }
        //                else
        //                {
        //                    if (isLeft)
        //                    {
        //                        var toLeft = LastsFromLeft[floor] * 2 + 1;
        //                        var toRight = ColCount + 2;
        //                        return Math.Min(GetDistance(true, floor + 1, total + toLeft),
        //                            GetDistance(false, floor + 1, total + toRight));
        //                    }
        //                    else
        //                    {
        //                        var toRight = LastsFromRight[floor] * 2 + 1;
        //                        var toLeft = ColCount + 2;
        //                        return Math.Min(GetDistance(true, floor + 1, total + toLeft),
        //                            GetDistance(false, floor + 1, total + toRight));
        //                    }
        //                }
        //            }


        //            static void Main(string[] args)
        //            {
        //                //using(StreamReader r = new StreamReader("input.txt"))
        //                //{
        //                var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //                //var buf = r.ReadLine().Split().Select(int.Parse).ToArray();

        //                FloorCount = buf[0];
        //                ColCount = buf[1];
        //                LastsFromLeft = new int[FloorCount];
        //                LastsFromRight = new int[FloorCount];

        //                for (int i = 0; i < FloorCount; i++)
        //                {
        //                    buf = Console.ReadLine().ToCharArray().Select(b => Convert.ToInt32(b) - 48).ToArray();
        //                    //buf = r.ReadLine().ToCharArray().Select(b => Convert.ToInt32(b) - 48).ToArray();


        //                    for (int j = 1; j <= ColCount; j++)
        //                    {
        //                        if (buf[j] == 1)
        //                        {
        //                            LastsFromLeft[i] = j;
        //                        }

        //                        if (LastsFromRight[i] == 0 && buf[j] == 1)
        //                        {
        //                            LastsFromRight[i] = ColCount + 1 - j;
        //                        }
        //                    }
        //                }

        //                for (int i = 0; i < FloorCount; i++)
        //                {
        //                    if (LastsFromLeft[i] != 0)
        //                    {
        //                        LastFloor = FloorCount - i - 1;
        //                        break;
        //                    }
        //                }

        //                Array.Reverse(LastsFromLeft);
        //                Array.Reverse(LastsFromRight);

        //                var result = GetDistance(true, 0, 0);

        //                Console.WriteLine(result);

        //            }
        //        }
        //    }

        #endregion
        #region Task 5 Edenichki
//        using System;
//using System.Linq;

//namespace AlgoContest
//    {
//        class Program
//        {
//            private static int K;
//            private static int N;
//            private static int Total;
//            static bool IsOk(int[,] a, int row, int col)
//            {
//                int i, j;
//                int n = a.GetLength(0);
//                for (i = 0; i < col; i++)
//                    if (a[row, i] == 1)
//                        return false;

//                for (i = 0; i < row; i++)
//                    if (a[i, col] == 1)
//                        return false;

//                //left bottom
//                for (i = row, j = col; i < n && j >= 0; i++, j--)
//                    if (a[i, j] == 1)
//                        return false;
//                //left top
//                for (i = row, j = col; j >= 0 && i >= 0; i--, j--)
//                    if (a[i, j] == 1)
//                        return false;

//                //right bottom
//                for (i = row, j = col; i < n && j < n; i++, j++)
//                    if (a[i, j] == 1)
//                        return false;

//                //right top
//                for (i = row, j = col; i >= 0 && j < n; i--, j++)
//                    if (a[i, j] == 1)
//                        return false;

//                return true;
//            }

//            static void AddOne(int[,] a, int left, int row, int col)
//            {
//                if (left == 0)
//                {
//                    Total++;
//                    if (col == 0)
//                    {
//                        a[row - 1, N - 1] = 0;
//                    }
//                    else
//                    {
//                        a[row, col - 1] = 0;
//                    }

//                    AddOne(a, left + 1, row, col);
//                    return;
//                }

//                if (row >= N || col >= N)
//                {
//                    return;
//                }

//                if (IsOk(a, row, col))
//                {
//                    a[row, col] = 1;

//                    if (col == N - 1)
//                        AddOne(a, left - 1, row + 1, 0);
//                    else
//                        AddOne(a, left - 1, row, col + 1);

//                    a[row, col] = 0;
//                }
//                else
//                {
//                    if (col == N - 1)
//                        AddOne(a, left, row + 1, 0);
//                    else
//                        AddOne(a, left, row, col + 1);
//                }
//            }

//            static void Main(string[] args)
//            {
//                var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//                N = buf[0];
//                K = buf[1];

//                if (K == 1)
//                {
//                    Console.WriteLine(N * N);
//                    return;
//                }

//                int[,] a = new int[N, N];

//                for (int i = 0; i < N; i++)
//                {
//                    for (int j = 0; j < N; j++)
//                    {
//                        AddOne(a, K, i, j);
//                    }
//                }

//                Console.WriteLine(Total);
//            }
//        }
//    }
    #endregion

    #region Task 6 Security

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

    #region Task 8 Korridor

    //using System;
    //using System.Linq;
    //using System.Collections.Generic;
    //using System.Diagnostics.CodeAnalysis;

    //namespace AlgoContest
    //{
    //    class Program
    //    {

    //        static int CountValue(int[,] f, int leftOne, int leftThree)
    //        {
    //            if (leftOne > )
    //        }

    //        static void Main(string[] args)
    //        {
    //            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
    //            int n = buf[0];
    //            int a = buf[1];
    //            int b = buf[2];
    //            var f = new int[n];
    //            f[0] = 1;
    //            f[1] = 1;
    //            f[2] = 2;

    //            for (int i = 3; i < n; i++)
    //            {
    //                f[i] = f[i - 1] + f[i - 3];
    //            }






    //            Console.WriteLine();
    //        }
    //    }
    //}

    #endregion
}
}
