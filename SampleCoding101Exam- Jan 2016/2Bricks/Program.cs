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
        int bricks = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int cart = int.Parse(Console.ReadLine());

        double hourly = workers * cart;
        Console.WriteLine(Math.Ceiling(bricks / hourly));
    }
}

