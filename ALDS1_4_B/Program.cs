using System;
using System.Collections.Generic;
using System.Linq;
namespace ALDS1_4_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine().Trim());
            var s = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToArray();
            var q = int.Parse(Console.ReadLine().Trim());
            var t = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            var cnt = 0;
            for (var i = 0; i < q; i++)
            {
                if (binarySearch(s, t[i], 0, n - 1))
                {
                    //Console.WriteLine(t[i]);
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }

        static bool binarySearch(int[] s, int t, int start, int end)
        {
            var mid = start + (int)((end - start) / 2);
            if (start > end)
            {
                return false;
            }
            else if (s[mid] == t)
            {
                return true;
            }
            else if (start == end)
            {
                return false;
            }
            else if (s[mid] > t)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
            return binarySearch(s, t, start, end);
        }
    }
}
