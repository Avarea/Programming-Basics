using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 28 August 2016

class Program
{
    static void Main()
    {
        int workingDaysInMonth = int.Parse(Console.ReadLine());
        double moneyEarnedDaily = double.Parse(Console.ReadLine());
        double dollar = double.Parse(Console.ReadLine());

        double monthlySallary = workingDaysInMonth * moneyEarnedDaily;
        double yearlySallary = (monthlySallary * 12) + (monthlySallary * 2.5);
        double taxes = yearlySallary * 0.25;
        double moneyPerYear = (yearlySallary - taxes) * dollar;
        Console.WriteLine("{0:f2}", moneyPerYear / 365);

    }
}

