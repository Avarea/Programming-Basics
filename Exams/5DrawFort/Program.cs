using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 6 March 2016

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cols = n / 2;
        int middle = n - n / 2 - 2;

        Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', cols), new string('_', 2 * middle));

        for (int i = 1; i <= n-2; i++)
        {
            if (i == n - 2)
            {
                Console.WriteLine("|{0}{1}{0}|", new string(' ', n - middle - 1), new string('_', 2 * middle));
            }
            else
            {
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 2)); 
            }
        }
        Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', cols), new string(' ', 2 * middle));
    }
}

