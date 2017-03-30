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
        int upperDots = (3 * n - 2) / 2;
        int upperSpaces = 0;
        //top
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}/{1}\\{0}", new string('.', upperDots), new string(' ', upperSpaces));
            upperDots--;
            upperSpaces = upperSpaces + 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n * 2));
        //mid
        for (int i = 1; i <= n * 2; i++)
        {
            Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', n * 2 - 2));
        }
        //bot
        int botDots = n / 2;
        int botStars = n * 2 - 2;

        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}/{1}\\{0}", new string('.', botDots), new string('*', botStars));
            botDots--;
            botStars = botStars + 2;
        }
    }
}

