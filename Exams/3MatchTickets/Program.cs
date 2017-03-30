using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 17 July 2016


class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int groupNumber = int.Parse(Console.ReadLine());

        double vip = 499.99;
        double normal = 249.99;
        if (groupNumber <= 4)
        {
            double transport = budget * 0.75;
            if (category == "VIP")
            {
                double total = transport + (vip * groupNumber);
                if (total > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(total - budget));
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(total - budget));
                }
            }
            else
            {
                double total = transport + (normal * groupNumber);
                if (total > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(total - budget));
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(total - budget));
                }
            }
        }

        else if (groupNumber <= 9)
        {
            double transport = budget * 0.60;
            if (category == "VIP")
            {
                double total = transport + (vip * groupNumber);
                if (total > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(total - budget));
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(total - budget));
                }
            }
            else
            {
                double total = transport + (normal * groupNumber);
                if (total > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(total - budget));
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(total - budget));
                }
            }
        }

        else if (groupNumber <= 24)
        {
            double transport = budget * 0.50;
            if (category == "VIP")
            {
                double total = transport + (vip * groupNumber);
                if (total > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(total - budget));
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(total - budget));
                }
            }
            else
            {
                double total = transport + (normal * groupNumber);
                if (total > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(total - budget));
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(total - budget));
                }
            }
        }
        else if (groupNumber <= 49)
        {
            double transport = budget * 0.40;
            if (category == "VIP")
            {
                double total = transport + (vip * groupNumber);
                if (total > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(total - budget));
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(total - budget));
                }
            }
            else
            {
                double total = transport + (normal * groupNumber);
                if (total > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(total - budget));
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(total - budget));
                }
            }
        }
        else if (groupNumber >= 50)
        {
            double transport = budget * 0.25;
            if (category == "VIP")
            {
                double total = transport + (vip * groupNumber);
                if (total > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(total - budget));
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(total - budget));
                }
            }
            else
            {
                double total = transport + (normal * groupNumber);
                if (total > budget)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(total - budget));
                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(total - budget));
                }
            }
        }
    }
}

