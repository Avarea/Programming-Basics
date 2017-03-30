using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int topDiez = 1;
        int topDots = ((12 * n - 5)) / 2;


        for (int i = 0; i < n * 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', topDots), new string('#', topDiez));
            topDiez += 6;
            topDots -= 3;
        }
        int botDotsLeft = 2;
        int botDotsRight = 3;
        int botDiezConstant = 6 * n + 1;


        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("|{0}{1}{2}", new string('.', botDotsLeft), new string('#', (topDiez - 12)), new string('.', botDotsRight));
            botDotsLeft += 3;
            botDotsRight += 3;
            topDiez -= 6;
        }


        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("|{0}{1}{2}", new string('.', botDotsLeft), new string ('#', botDiezConstant), new string('.', botDotsRight));
        }
        Console.WriteLine("@{0}{1}{2}", new string('.', botDotsLeft), new string('#', botDiezConstant), new string('.', botDotsRight));
    }
}

