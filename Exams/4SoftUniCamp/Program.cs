using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 20 November 2016 - Morning

class Program
{
    static void Main()
    {
        int groups = int.Parse(Console.ReadLine());
        double car = 0;
        double microbus = 0;
        double smallBus = 0;
        double bigBus = 0;
        double train = 0;
        int totalTravelers = 0;

        for (int i = 0; i < groups; i++)
        {
            int countOfGroup = int.Parse(Console.ReadLine());
            totalTravelers += countOfGroup;
            if (countOfGroup <= 5) 
            {
                car += countOfGroup;
            }
            else if (countOfGroup <=12)
            {
                microbus += countOfGroup;
            }
            else if (countOfGroup <=25)
            {
                smallBus += countOfGroup;
            }
            else if (countOfGroup <=40)
            {
                bigBus += countOfGroup;
            }
            else
            {
                train += countOfGroup;
            }
        }
        Console.WriteLine("{0:f2}%", car / totalTravelers *100);
        Console.WriteLine("{0:f2}%", microbus / totalTravelers * 100);
        Console.WriteLine("{0:f2}%", smallBus / totalTravelers * 100);
        Console.WriteLine("{0:f2}%", bigBus / totalTravelers * 100);
        Console.WriteLine("{0:f2}%", train / totalTravelers * 100);
    }
}

