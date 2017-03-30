using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 26 March 2016


class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        double budgetLeft = 0;

        if (budget <= 100)
        {
            if (season == "summer")
            {
                budgetLeft = (budget * 0.3);
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:f2}", budgetLeft);
            }
            else
            {
                budgetLeft = (budget * 0.7);
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:f2}", budgetLeft);
            }
        }
        if (100 < budget && budget <= 1000)
        {
            if (season == "summer")
            {
                budgetLeft = (budget * 0.4);
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:f2}", budgetLeft);
            }
            else
            {
                budgetLeft = (budget * 0.8);
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:f2}", budgetLeft);
            }
        }
        if (budget > 1000)
        {
            budgetLeft = (budget * 0.9);
            Console.WriteLine("Somewhere in Europe");
            Console.WriteLine("Hotel - {0:f2}", budgetLeft);
        }
    }
}

