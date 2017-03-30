using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Програмиране за начинаещи" – 17 юли 2016

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int topDotsStart = n;
        int topStarsMid = 3 * n;
        Console.WriteLine("{0}{1}{0}", new string('.', topDotsStart), new string('*', topStarsMid));
        for (int i = 1; i <= n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', topDotsStart - 1), new string('.', topStarsMid));
            topDotsStart--;
            topStarsMid += 2;
        }
        Console.WriteLine("{0}", new string('*', 5*n));

        int botDotsStart = 1;
        int botDotsMid = 5 * n - 4;
        for (int i = 1; i <= 3 * n -n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', botDotsStart), new string('.', botDotsMid));
            botDotsStart++;
            botDotsMid -= 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n-2));
    }
}
