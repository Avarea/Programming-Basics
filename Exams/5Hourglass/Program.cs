using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Основи на програмирането" – 19 март 2017 сутрин


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}", new string('*', 2 * n + 1));
        Console.WriteLine(".*{0}*.", new string(' ', (2 * n+ 1) - 4));

        int topDots = 2;
        int topFill = 2 * n + 1 - 6;

        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('.', topDots), new string('@', topFill));
            topDots++;
            topFill -= 2;
        }
        Console.WriteLine("{0}*{0}", new string('.', topDots));
        int botSpace = 0;
        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', topDots -1), new string(' ', botSpace));
            topDots--;
            botSpace++;
        }
        Console.WriteLine(".*{0}*.", new string('@', (2 * n + 1) - 4));
        Console.WriteLine("{0}", new string('*', 2 * n + 1));

    }
}

