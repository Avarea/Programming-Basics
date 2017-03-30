using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sample Coding 101 Exam - Jan 2016

class Program
{
    static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        double a = Math.Abs(x2 - x3);
        double h = Math.Abs(y1 - y2);
        double area = a * h / 2;
        Console.WriteLine(area);
    }
}

