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
        int firstSpeed = int.Parse(Console.ReadLine());
        int firstTime = int.Parse(Console.ReadLine());
        int secondTime = int.Parse(Console.ReadLine());
        int thirdTime = int.Parse(Console.ReadLine());

        double minutesToHours = 60;

        double secondSpeed = firstSpeed + (firstSpeed * 0.1);
        double thirdSpeed = secondSpeed - (secondSpeed * 0.05);

        double firstHour = firstTime / minutesToHours;
        double secondHour = secondTime / minutesToHours;
        double thirdHour = thirdTime / minutesToHours;


        double firstDinstance = firstSpeed * firstHour;
        double secondDinstance = secondSpeed * secondHour;
        double thirdDinstance = thirdSpeed * thirdHour;

        double Distance = firstDinstance + secondDinstance + thirdDinstance;

        Console.WriteLine("{0:f2}", Distance);


    }
}

