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
    }
}
