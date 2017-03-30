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
        int days = int.Parse(Console.ReadLine());
        int food = int.Parse(Console.ReadLine());
        double dogFood = double.Parse(Console.ReadLine());
        double catFood = double.Parse(Console.ReadLine());
        double turtleFood = double.Parse(Console.ReadLine());

        double TotalFoodLeft = (dogFood * days) + (catFood * days) + (turtleFood * days/1000);

        if (food >= TotalFoodLeft)
        {
            Console.WriteLine("{0} kilos of food left.", Math.Floor(Math.Abs(food - TotalFoodLeft)));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(Math.Abs(food - TotalFoodLeft)));
        }
    }
}

