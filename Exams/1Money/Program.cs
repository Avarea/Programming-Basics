using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 17 July 2016


class Program
{
    static void Main()
    {
        int bitcoins = int.Parse(Console.ReadLine());
        double juan = double.Parse(Console.ReadLine());
        double commision = double.Parse(Console.ReadLine());

        double dollars = 0.15 * juan;
        double leva = (1168 * bitcoins) + (dollars * 1.76);
        double evro = leva / 1.95;
        Console.WriteLine(evro - (evro * commision/100));
    }
}

