using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 19 March 2017 - Evening


class Problem3
{
    static void Main()
    {
        string season = Console.ReadLine();
        double kilometersPerMonth = double.Parse(Console.ReadLine());

        if (kilometersPerMonth > 10000 && 20000 >= kilometersPerMonth )
        {
            double totalPay = (kilometersPerMonth * 1.45) * 4;
            double afterTaxes = totalPay - (totalPay * 0.1);
            Console.WriteLine("{0:f2}", afterTaxes );
        }

        if (5000 < kilometersPerMonth && kilometersPerMonth <= 10000)
        {
            if (season == "Spring" || season == "Autumn")
            {
                double totalPay = (kilometersPerMonth * 0.95) * 4;
                double afterTaxes = totalPay - (totalPay * 0.1);
                Console.WriteLine("{0:f2}", afterTaxes);
            }
            else if (season == "Summer")
            {
                double totalPay = (kilometersPerMonth * 1.10) * 4;
                double afterTaxes = totalPay - (totalPay * 0.1);
                Console.WriteLine("{0:f2}", afterTaxes);
            }
            else
            {
                double totalPay = (kilometersPerMonth * 1.25) * 4;
                double afterTaxes = totalPay - (totalPay * 0.1);
                Console.WriteLine("{0:f2}", afterTaxes);
            }
        }
        if (kilometersPerMonth <=5000)
        {
            if (season == "Spring" || season == "Autumn")
            {
                double totalPay = (kilometersPerMonth * 0.75) * 4;
                double afterTaxes = totalPay - (totalPay * 0.1);
                Console.WriteLine("{0:f2}", afterTaxes);
            }
            else if (season == "Summer")
            {
                double totalPay = (kilometersPerMonth * 0.9) * 4;
                double afterTaxes = totalPay - (totalPay * 0.1);
                Console.WriteLine("{0:f2}", afterTaxes);
            }
            else
            {
                double totalPay = (kilometersPerMonth * 1.05) * 4;
                double afterTaxes = totalPay - (totalPay * 0.1);
                Console.WriteLine("{0:f2}", afterTaxes);
            }
        }
    }
}

