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
        //top
        int topTire = 0;
        int topTire2 = (2 * n) - 2;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('-', 3*n), new string('-', topTire), new string('-', topTire2));
            topTire++;
            topTire2--;
        }
        //mid
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}*{1}", new string('*', 3 * n + 1), new string('-', n - 1));
        }
        //bot
        int botTireta1 = 3 * n;
        int botTireta2 = n - 1;
        int botTireta3 = n - 1;
        for (int i = 1; i <= n /2 -1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('-', botTireta1), new string('-', botTireta2), new string('-', botTireta3));
            botTireta1--;
            botTireta2 = botTireta2 + 2;
            botTireta3--;
        }
        botTireta2 += 2;
        int dawdwadaw = (int)Math.Ceiling((double) n / 2);
        Console.WriteLine("{0}{1}{2}", new string('-', botTireta1), new string('*', botTireta2), new string('-', dawdwadaw));

    }
}

