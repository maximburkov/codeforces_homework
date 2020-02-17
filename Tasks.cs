using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoContest
{
    static class Tasks
    {

    }
}

#region Task 1 Searching
//using System;
//using System.Linq;

//namespace AlgoContest
//{
//    class Program
//    {
//static int[] Generate(int n, int min, int max)
//{
//    int[] arr = new int[n];
//    Random r = new Random();
//    for (int i = 0; i < n; i++)
//    {
//        arr[i] = r.Next(min, max);
//    }
//    return arr;
//}

//        static int BinarySearch(int[] a, int find, int l, int r)
//        {
//            if (l == r) return l;
//            int m = (l + r) / 2;
//            if (a[m] >= find && (m == 0 || a[m - 1] < find))
//                return m;
//            if (a[m] < find)
//                return BinarySearch(a, find, m + 1, r);
//            else
//                return BinarySearch(a, find, l, m - 1);
//        }

//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int k = int.Parse(Console.ReadLine());
//            int[] q = Console.ReadLine().Split().Select(int.Parse).ToArray();

//            Array.Sort(a);

//            for (int i = 0; i < k; i++)
//            {
//                if (a[n - 1] < q[i])
//                    q[i] = n;
//                else
//                    q[i] = BinarySearch(a, q[i], 0, n - 1);
//            }

//            Console.Write(string.Join(" ", q));
//            //Console.ReadKey();
//        }
//    }
//}
#endregion

#region Task 2 Drink
//using System;
//using System.Linq;

//namespace AlgoContest
//{
//    class Program
//    {
//        static int BinarySearch(int[] a, int find, int l, int r)
//        {
//            if (l == r) return l;
//            int m = (l + r) / 2;
//            if (a[m] > find && (m == 0 || a[m - 1] <= find))
//                return m;
//            if (a[m] <= find)
//                return BinarySearch(a, find, m + 1, r);
//            else
//                return BinarySearch(a, find, l, m - 1);
//        }

//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int q = int.Parse(Console.ReadLine());
//            int[] m = new int[q];
//            for (int i = 0; i < q; i++)
//            {
//                m[i] = int.Parse(Console.ReadLine());
//            }

//            Array.Sort(a);
//            for (int i = 0; i < q; i++)
//            {
//                if (a[n - 1] <= m[i])
//                    Console.WriteLine(n);
//                else
//                    Console.WriteLine(BinarySearch(a, m[i], 0, n - 1));
//            }
//        }
//    }
//}
#endregion

#region Task 3 Fonari Unchecked
//using System;
//using System.Linq;

//namespace AlgoContest
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int n = buf[0];
//            int l = buf[1];
//            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

//            Array.Sort(a);
//            int pointer = a[0];
//            int maxDist = pointer * 2;

//            for (int i = 1; i < n; i++)
//            {
//                var dist = a[i] - pointer;
//                if (dist > maxDist)
//                    maxDist = dist;
//                pointer = a[i];
//            }

//            int toEnd = (l - a[n - 1]) * 2;
//            if (toEnd > maxDist)
//                maxDist = toEnd;

//            Console.WriteLine((double)maxDist / 2);
//        }
//    }
//}
#endregion

#region Task 4 Playlist
//using System;
//using System.Linq;

//namespace AlgoContest
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int n = buf[0];
//            int m = buf[1];
//            int[] lengths = new int[n];

//            buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            lengths[0] = buf[0] * buf[1];
//            for (int i = 1; i < n; i++)
//            {
//                buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//                lengths[i] = lengths[i - 1] + (buf[0] * buf[1]);
//            }

//            int[] moments = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int songIndex = 0;
//            for (int i = 0; i < m; i++)
//            {
//                int moment = moments[i];
//                while (moment > lengths[songIndex])
//                    songIndex++;

//                Console.WriteLine(songIndex + 1);
//            }
//        }
//    }
//}
#endregion

#region Task 5 Tomsk
//using System;
//using System.Linq;

//namespace AlgoContest
//{
//    class Program
//    {
//        struct City : IComparable<City>
//        {
//            public int x;
//            public int y;
//            public int population;
//            public int CompareTo(City toCompare)
//            {
//                double thisRadius = GetRadius(x, y);
//                double toCompareRadius = GetRadius(toCompare.x, toCompare.y);

//                if (thisRadius > toCompareRadius)
//                    return 1;
//                else if (thisRadius < toCompareRadius)
//                    return -1;
//                else
//                    return 0;
//            }
//        }

//        static double GetRadius(int x, int y)
//        {
//            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
//        }

//        static void Main(string[] args)
//        {
//            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int n = buf[0];
//            int s = buf[1];
//            City[] cities = new City[n];

//            for (int i = 0; i < n; i++)
//            {
//                buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//                cities[i] = new City { x = buf[0], y = buf[1], population = buf[2] };
//            }

//            Array.Sort(cities);

//            for (int i = 0; i < n; i++)
//            {
//                s += cities[i].population;
//                if (s >= 1000000)
//                {
//                    Console.WriteLine(GetRadius(cities[i].x, cities[i].y));
//                    return;
//                }
//            }

//            Console.WriteLine(-1);
//        }
//    }
//}
#endregion

#region Task 6 Polshar
//using System;
//using System.Linq;

//namespace AlgoContest
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int p = buf[0];
//            int v = buf[1];

//            if (p > v)
//            {
//                Console.WriteLine("YES");
//                return;
//            }

//            if (v > p)
//            {
//                Console.WriteLine("NO");
//                return;
//            }

//            string[] pwords = new string[p];
//            string[] vwords = new string[v];

//            for (int i = 0; i < p; i++)
//            {
//                pwords[i] = Console.ReadLine();
//            }

//            for (int i = 0; i < v; i++)
//            {
//                vwords[i] = Console.ReadLine();
//            }

//            if (pwords.Intersect(vwords).Count() % 2 == 1)
//            {
//                Console.WriteLine("YES");
//            }
//            else
//            {
//                Console.WriteLine("NO");
//            }
//        }
//    }
//}
#endregion

#region Task 7 
/*
 * using System;
using System.Linq;

namespace AlgoContest
{
    class Program
    {
        struct Message
        {
            public string Name;
            public int number;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Message [] list = new Message[n];

            for (int i = 0; i < n; i++)
            {
                list[i] = new Message{Name = Console.ReadLine(), number = i}; 
            }

            var res = list.GroupBy(i => i.Name).Select(i => i.Max(l => l.number)).ToArray();
            Array.Sort(res);

            for (int i = res.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(list[res[i]].Name);
            }
        }
    }
}
 */
#endregion

#region Task 8
//using System;
//using System.Linq;

//namespace AlgoContest
//{
//    class Program
//    {
//        static int limit = 1000005;
//        static void Main(string[] args)
//        {
//            var n = int.Parse(Console.ReadLine());
//            int[] a = new int[limit];
//            int[] places = new int[n];
//            int max = 0;

//            for (int i = 0; i < n; i++)
//            {
//                var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//                a[buf[0]] = buf[1];
//                places[i] = buf[0];
//                if (i == n - 1)
//                {
//                    max = buf[0];
//                }
//            }

//            int[] res = new int[limit];
//            int maxAlive = 0;

//            if (a[0] > 0)
//            {
//                res[0] = 1;
//            }

//            for (int i = 1; i <= limit; i++)
//            {
//                if (a[i] == 0)
//                {
//                    res[i] = res[i - 1];
//                }
//                else
//                {
//                    if (a[i] >= i)
//                        res[i] = 1;
//                    else
//                    {
//                        res[i] = res[i - a[i] - 1] + 1;
//                    }
//                }

//                if (res[i] > maxAlive)
//                    maxAlive = res[i];
//            }

//            Console.WriteLine(n - maxAlive);

//        }
//    }
//}
#endregion


