using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP1_7_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new List<int[]>();
            while (true)
            {
                var line = Console.ReadLine().Trim().Split(" ").Select(x => int.Parse(x)).ToArray();
                if (line[0] == 0 && line[1] == 0) break;
                lines.Add(line);
            }
            foreach (var l in lines)
            {
                var cnt = check(l[0], l[1]);
                Console.WriteLine(cnt);
            }

        }

        static int check(int n, int x)
        {
            var cnt = 0;
            for (var a = 1; a <= n - 2; a++)
            {
                for (var b = a + 1; b <= n - 1; b++)
                {
                    for (var c = b + 1; c <= n; c++)
                    {
                        if (a + b + c == x)
                        {
                            cnt++;
                        }
                    }
                }
            }
            return cnt;
        }
    }
}
