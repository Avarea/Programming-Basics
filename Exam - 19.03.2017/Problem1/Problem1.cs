using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 19 March 2017 - Evening

class Problem1
{
    static void Main()
    {
        double area = double.Parse(Console.ReadLine());
        double kilogramsPerSquareMeter = double.Parse(Console.ReadLine());
        double trash = double.Parse(Console.ReadLine());

        double totalGrape = area * kilogramsPerSquareMeter - trash;

        double rakia = totalGrape * 0.45;
        double rakiaIncome = (rakia / 7.5) * 9.8;

        double sale = totalGrape * 0.55;
        double saleIncome = sale * 1.5;

        Console.WriteLine("{0:f2}", rakiaIncome);
        Console.WriteLine("{0:f2}", saleIncome);

    }
}

