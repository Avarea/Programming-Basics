using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 20 November 2016 - Evening


class Program
{
    static void Main()
    {
        int juniorRacers = int.Parse(Console.ReadLine());
        int seniorRacers = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();

        double juniorTrail = 5.50;
        double juniorCross = 8.00;
        double juniorDownhill = 12.25;
        double juniorRoad = 20.00;
        double seniorTrail = 7.00;
        double seniorCross = 9.50;
        double seniorDownhill = 13.75;
        double senuiorRoad = 21.50;

        int totalRacers = juniorRacers + seniorRacers;

        if (type == "trail")
        {
                double taxes = ((juniorRacers * juniorTrail) + (seniorRacers * seniorTrail));
                double taxesFinal = taxes - (taxes * 0.05);
                Console.WriteLine("{0:f2}", taxesFinal);
        }
        else if (type == "cross-country")
        {
            if (totalRacers >= 50)
            {
                double taxes = ((juniorRacers * juniorCross) + (seniorRacers * seniorCross)) - (((juniorRacers * juniorCross) + (seniorRacers * seniorCross)) * 0.25);
                double taxesFinal = taxes - (taxes * 0.05);
                Console.WriteLine("{0:f2}", taxesFinal);
            }
            else
            {
                double taxes = ((juniorRacers * juniorCross) + (seniorRacers * seniorCross));
                double taxesFinal = taxes - (taxes * 0.05);
                Console.WriteLine("{0:f2}", taxesFinal);
            }
        }
        else if (type == "downhill")
        {
                double taxes = ((juniorRacers * juniorDownhill) + (seniorRacers * seniorDownhill));
                double taxesFinal = taxes - (taxes * 0.05);
                Console.WriteLine("{0:f2}", taxesFinal);
        }
        else
        {

                double taxes = ((juniorRacers * juniorRoad) + (seniorRacers * senuiorRoad));
                double taxesFinal = taxes - (taxes * 0.05);
                Console.WriteLine("{0:f2}", taxesFinal);
        }


    }
}

