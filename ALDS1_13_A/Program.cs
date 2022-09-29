using System;
using System.Collections.Generic;
using System.Linq;
namespace ALDS1_13_A
{
    class Program
    {
        static bool[,] ans = new bool[8, 8];
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine().Trim());
            var board = new bool[8, 8];
            for (var i = 0; i < k; i++)
            {
                var a1 = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToArray();
                board[a1[0], a1[1]] = true;
                ans[a1[0], a1[1]] = true;
            }
            tansaku(board, k);
            writeBoard(ans);
        }

        static bool tansaku(bool[,] board, int cnt)
        {
            //Console.WriteLine(cnt);
            if (cnt == 8)
            {
                return true;
            }
            for (var x = 0; x < 8; x++)
            {
                for (var y = 0; y < 8; y++)
                {
                    if (canPutQueen(board, x, y))
                    {
                        var board2 = (bool[,])board.Clone();
                        board2[x, y] = true;
                        var ret = tansaku(board2, cnt + 1);
                        if (ret)
                        {
                            ans[x, y] = true;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        static bool canPutQueen(bool[,] board, int x, int y)
        {
            var ret = true;
            for (var i = 0; i < 8; i++)
            {
                if (board[x, i])
                {
                    ret = false;
                    break;
                }
                else if (board[i, y])
                {
                    ret = false;
                    break;
                }
                else if (x - i >= 0 && y - i >= 0 && board[x - i, y - i])
                {
                    ret = false;
                    break;
                }
                else if (x + i < 8 && y + i < 8 && board[x + i, y + i])
                {
                    ret = false;
                    break;
                }
                else if (x - i >= 0 && y + i < 8 && board[x - i, y + i])
                {
                    ret = false;
                    break;
                }
                else if (x + i < 8 && y - i >= 0 && board[x + i, y - i])
                {
                    ret = false;
                    break;
                }
            }
            return ret;
        }

        static void writeBoard(bool[,] board)
        {
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    if (board[i, j])
                    {
                        Console.Write('Q');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
