using System;
using System.Linq;

namespace AlgoContest
{
    class Program
    {
        struct City : IComparable<City>
        {
            public int x;
            public int y;
            public int population;
            public int CompareTo(City toCompare)
            {
                double thisRadius = GetRadius(x, y);
                double toCompareRadius = GetRadius(toCompare.x, toCompare.y);

                if (thisRadius > toCompareRadius)
                    return 1;
                else if (thisRadius < toCompareRadius)
                    return -1;
                else
                    return 0;
            }
        }

        static double GetRadius(int x, int y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        static void Main(string[] args)
        {
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = buf[0];
            int s = buf[1];
            City[] cities = new City[n];

            for (int i = 0; i < n; i++)
            {
                buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
                cities[i] = new City {x = buf[0], y = buf[1], population = buf[2]};
            }

            Array.Sort(cities);

            for (int i = 0; i < n; i++)
            {
                s += cities[i].population;
                if (s >= 1000000)
                {
                    Console.WriteLine(GetRadius(cities[i].x, cities[i].y));
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}

