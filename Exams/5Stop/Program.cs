using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 24 April 2016

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int topDots = n + 1;
        int topDashes = 2 * n - 1;
        Console.WriteLine("{0}{1}{0}", new string('.', topDots), new string('_', 2*n + 1));
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}//{1}\\\\{0}", new string('.', topDots -1), new string('_', topDashes));
            topDots--;
            topDashes += 2;
        }
        Console.WriteLine("//{0}STOP!{0}\\\\", new string('_',n* 2 -3));
        int botDashes = 4 * n - 1;
        int botDots = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}\\\\{1}//{0}",new string('.', botDots), new string('_', botDashes));
            botDots++;
            botDashes -= 2;
        }
    }
}

