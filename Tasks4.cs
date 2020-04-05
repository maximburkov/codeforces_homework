using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoContest
{
    class Tasks4
    {
        #region Task 1 Kletki
        //using System;
        //using System.IO;
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
        //            var rows = new bool[n];
        //            var cols = new bool[n];
        //            var count = (long)n * n;
        //            int rowCount = 0;
        //            int colCount = 0;

        //            for (int i = 0; i < m; i++)
        //            {
        //                buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //                int row = buf[0] - 1;
        //                int col = buf[1] - 1;

        //                if (!rows[row])
        //                {
        //                    rowCount++;
        //                    rows[row] = true;
        //                    count -= (n - colCount);
        //                }

        //                if (!cols[col])
        //                {
        //                    colCount++;
        //                    cols[col] = true;
        //                    count -= (n - rowCount);
        //                }

        //                Console.WriteLine(count);
        //            }
        //        }
        //    }
        //}
        #endregion

        #region Task 2 Bad sequence
        //using System;
        //using System.Collections.Generic;
        //using System.IO;
        //using System.Linq;

        //namespace AlgoContest
        //{
        //    class Program
        //    {

        //        static void Main(string[] args)
        //        {
        //            int n = int.Parse(Console.ReadLine());
        //            var arr = Console.ReadLine().ToCharArray();
        //            Stack<char> stack = new Stack<char>(arr.Length);

        //            if (n == 0)
        //            {
        //                Console.WriteLine("Yes");
        //                return;
        //            }
        //            else if (n % 2 != 0)
        //            {
        //                Console.WriteLine("No");
        //                return;
        //            }

        //            for (int i = 0; i < n; i++)
        //            {
        //                var b = arr[i];
        //                if (b == '(')
        //                {
        //                    stack.Push(b);
        //                }
        //                else
        //                {
        //                    if (stack.Count == 0)
        //                    {
        //                        stack.Push(b);
        //                    }
        //                    else
        //                    {
        //                        if (stack.Peek() == '(')
        //                        {
        //                            stack.Pop();
        //                        }
        //                        else
        //                        {
        //                            stack.Push(b);
        //                        }
        //                    }
        //                }
        //            }

        //            if (stack.Count == 0)
        //            {
        //                Console.WriteLine("Yes");
        //            }
        //            else if (stack.Count == 2)
        //            {
        //                var first = stack.Pop();
        //                var second = stack.Pop();
        //                Console.WriteLine(first == second ? "No" : "Yes");
        //            }
        //            else
        //            {
        //                Console.WriteLine("No");
        //            }
        //        }
        //    }
        //}
        #endregion
    }
}
