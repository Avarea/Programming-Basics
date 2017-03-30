using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Основи на програмирането" – 18 март 2016

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        if (season == "Summer")
        {
            if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                Console.WriteLine("Jeep - {0:f2}", budget * 0.9);
            }
            else if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                Console.WriteLine("Cabrio - {0:f2}", budget * 0.45);
            }
            else
            {
                Console.WriteLine("Economy class");
                Console.WriteLine("Cabrio - {0:f2}", budget * 0.35);
            }
        }

        else
        {
            if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                Console.WriteLine("Jeep - {0:f2}", budget * 0.9);
            }
            else if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                Console.WriteLine("Jeep - {0:f2}", budget * 0.8);
            }
            else
            {
                Console.WriteLine("Economy class");
                Console.WriteLine("Jeep - {0:f2}", budget * 0.65);
            }
        }

    }
}

