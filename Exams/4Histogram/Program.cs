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
        int start = int.Parse(Console.ReadLine());
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;

        for (int i = 1; i <= start; i++)
        {
            int numbers = int.Parse(Console.ReadLine());

            if (numbers < 200)
            {
                p1++;
            }
            else if (200 <= numbers && numbers < 400)
            {
                p2++;
            }
            else if (400 <= numbers && numbers <600)
            {
                p3++;
            }
            else if (600 <= numbers && numbers < 800)
            {
                p4++;
            }
            else
            {
                p5++;
            }
        }
        Console.WriteLine("{0:f2}%", p1 / start * 100);
        Console.WriteLine("{0:f2}%", p2 / start * 100);
        Console.WriteLine("{0:f2}%", p3 / start * 100);
        Console.WriteLine("{0:f2}%", p4 / start * 100);
        Console.WriteLine("{0:f2}%", p5 / start * 100);

    }
}

