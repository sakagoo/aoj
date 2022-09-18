using System;
using System.Linq;
namespace ALDS1_2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var flg = true;
            var count = 0;
            while (flg)
            {
                flg = false;
                for (var j = N - 1; j >= 1; j--)
                {
                    var i = j - 1;
                    if (A[i] > A[j])
                    {
                        //(A[i], A[j]) = (A[j], A[i]);
                        var w = A[i];
                        A[i] = A[j];
                        A[j] = w;
                        count++;
                        flg = true;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", A.Select(l => l.ToString())));
            Console.WriteLine(count);
        }
    }
}
