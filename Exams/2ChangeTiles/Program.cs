using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 18 December 2016

class Program
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        double floorWeight = double.Parse(Console.ReadLine());
        double floorHeight = double.Parse(Console.ReadLine());
        double triangleSide = double.Parse(Console.ReadLine());
        double triangleHieght = double.Parse(Console.ReadLine());
        double tilePrice = double.Parse(Console.ReadLine());
        double workerFee = double.Parse(Console.ReadLine());

        double floorArea = floorHeight * floorWeight;
        double tileArea = triangleHieght * triangleSide / 2;
        double tilesNeeded = Math.Ceiling((floorArea / tileArea)) + 5;
        double totalCosts = tilesNeeded * tilePrice + workerFee;

        if (totalCosts >money)
        {
            Console.WriteLine("You'll need {0:f2} lv more.", Math.Abs(totalCosts - money));
        }
        else
        {
            Console.WriteLine("{0:f2} lv left.", Math.Abs(totalCosts - money));
        }

    }
}

