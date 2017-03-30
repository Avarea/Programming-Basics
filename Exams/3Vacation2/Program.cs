using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Основи на програмирането" – 19 март 2017 сутрин


class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();


        if (budget > 3000)
        {
            if (season == "Summer")
            {
                Console.WriteLine("Alaska - Hotel - {0:f2}", budget * 0.9);
            }
            if (season == "Winter")
            {
                Console.WriteLine("Morocco - Hotel - {0:f2}", budget * 0.9);
            }
        }
        else if (1000 < budget && budget <= 3000)
        {
            if (season == "Summer")
            {
                Console.WriteLine("Alaska - Hut - {0:f2}", budget * 0.8);
            }
            if (season == "Winter")
            {
                Console.WriteLine("Morocco - Hut - {0:f2}", budget * 0.6);
            }
        }
        else
        {
            if (season == "Summer")
            {
                Console.WriteLine("Alaska - Camp - {0:f2}", budget * 0.65);
            }
            if (season == "Winter")
            {
                Console.WriteLine("Morocco - Camp - {0:f2}", budget * 0.45);
            }
        }
    }
}

