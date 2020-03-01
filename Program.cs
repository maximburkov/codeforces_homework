using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgoContest
{
    struct Option
    {
        public int A;
        public int B;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = buf[0];
            int a = buf[1]; //1m count
            int b = buf[2]; //3m count
            var f = new List<Option>[n];

            if (a > 0)
            {
                f[0] = new List<Option>{new Option{A = a - 1, B = b}};
            }
            else
            {
                f[0] = new List<Option>(0);
            }

            if (n > 1)
            {
                if (a > 1)
                {
                    f[1] = new List<Option> { new Option { A = a - 2, B = b } };
                }
                else
                {
                    f[1] = new List<Option>(0);
                }
            }

            if(n > 2)
            {
                var options = new List<Option>(2);
                if (a > 2)
                {
                    options.Add(new Option{A = a - 3, B = b});
                }

                if (b > 0)
                {
                    options.Add(new Option {A = a, B = b - 1});
                }

                f[2] = options;
            }

            for (int i = 3; i < n; i++)
            {
                var first = f[i - 1].Where(o => o.A > 0).Select(o =>
                {
                    o.A--;
                    return o;
                }).ToList();
                var second = (f[i - 3].Where(o => o.B > 0).Select(o =>
                {
                    o.B--;
                    return o;
                })).ToList();

                f[i-3].Clear();
                f[i - 3] = null;

                first.AddRange(second);
                f[i] = first;
            }

            Console.WriteLine(f[n - 1].Count % 1000000009);
        }
    }
}
