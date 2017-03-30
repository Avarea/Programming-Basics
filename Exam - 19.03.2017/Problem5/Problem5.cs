using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 19 March 2017 - Evening

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int topDotsLeft = 0;
        int topDotsRight = 2 * n;

        Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.', 2 * n + 1));
        for (int i = 1; i <= 2 * n + 1; i++)
        {
            Console.WriteLine("|{0}\\{1}\\{2}", new string('.', topDotsLeft), new string('~', n - 2), new string('.', topDotsRight));
            topDotsLeft++;
            topDotsRight--;
        }
        int botDotsLeft = 0;
        int botDotsRight = 2 * n;
        for (int i = 1; i <= 2 * n + 1; i++)
        {
            Console.WriteLine("{0}\\{1}|{2}|", new string('.', botDotsLeft), new string('.', botDotsRight), new string('~', n - 2));
            botDotsLeft++;
            botDotsRight--;
        }
        Console.WriteLine("{0}+{1}+", new string('.', 2 * n + 1),new string('~', n - 2));

    }
}

