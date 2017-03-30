using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 18 December 2016

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int tochki = n * 2 - 1;
        int tireta = 0;

        Console.WriteLine("{0}/|\\{0}", new string('.', ((4 * n + 1) / 2) - 1));
        Console.WriteLine("{0}\\|/{0}", new string('.', ((4 * n + 1) / 2) - 1));


        for (int j = 1; j <= 2 * n; j++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', tochki), new string('-', tireta));
            tochki--;
            tireta++;
        }

            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', 4 * n + 1));
        
    }
}

