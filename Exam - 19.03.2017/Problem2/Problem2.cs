using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 19 March 2017 - Evening


class Problem2
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double houseArea = double.Parse(Console.ReadLine());
        int windows = int.Parse(Console.ReadLine());
        double sqrMetersStyrofoamPerPackage = double.Parse(Console.ReadLine());
        double pricePerPackage = double.Parse(Console.ReadLine());

        double totalHouseArea = houseArea - (windows * 2.4);
        double neededStyrofoam = totalHouseArea + (totalHouseArea * 0.1);

        double packagesNeeded = Math.Ceiling(neededStyrofoam / sqrMetersStyrofoamPerPackage);
        double moneyNeeded = packagesNeeded * pricePerPackage;

        if (moneyNeeded <= budget)
        {
            Console.WriteLine("Spent: {0:f2}", moneyNeeded);
            Console.WriteLine("Left: {0:f2}", Math.Abs(moneyNeeded - budget));
        }
        else
        {
            Console.WriteLine("Need more: {0:f2}", Math.Abs(moneyNeeded - budget));
        }

    }
}

