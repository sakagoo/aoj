using System;
using System.Collections.Generic;
using System.Linq;

namespace ALDS1_5_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            int[] A = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToArray();
            int q = int.Parse(Console.ReadLine().Trim());
            int[] m = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToArray();
            var ans = Enumerable.Repeat<bool>(false, q).ToArray();

            var result = new List<int>() { 0 };
            for (int i = 0; i < n; i++)
            {
                var len = result.Count();
                for (var j = 0; j < len; j++)
                {
                    var x = result[j] + A[i];
                    if (x <= 2000 && !result.Contains(x))
                    {
                        result.Add(x);
                        for (int k = 0; k < q; k++)
                        {
                            if (m[k] == x)
                            {
                                ans[k] = true;
                                //break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < q; i++)
            {
                if (ans[i])
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");

                }
            }
        }
    }
}
