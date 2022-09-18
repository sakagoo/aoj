using System;
using System.Linq;

namespace ALDS1_1_A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                insertionSort(A, N) // N個の要素を含む0-オリジンの配列A
                2   for i が 1 から N-1 まで
                3     v = A[i]
                4     j = i - 1
                5     while j >= 0 かつ A[j] > v
                6       A[j+1] = A[j]
                7       j--
                8     A[j+1] = v
            */
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            Console.WriteLine(string.Join(" ", A));

            for (var i = 1; i <= N - 1; i++)
            {
                var v = A[i];
                var j = i - 1;
                while (j >= 0 && A[j] > v)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = v;
                Console.WriteLine(string.Join(" ", A.Select(l => l.ToString())));
            }
        }
    }
}
