using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 6 March 2016


class Program
{
    static void Main()
    {
        int hourOfExam = int.Parse(Console.ReadLine());
        int minuteOfExam = int.Parse(Console.ReadLine());
        int hourofArrival = int.Parse(Console.ReadLine());
        int minuteofArrival = int.Parse(Console.ReadLine());

        int examTime = hourOfExam * 60 + minuteOfExam;
        int arrivalTime = hourofArrival * 60 + minuteofArrival;
        int differenceInMinutes = arrivalTime - examTime;

        if (differenceInMinutes < -30)
        {
            Console.WriteLine("Early");
        }
        else if (differenceInMinutes <= 0)
        {
            Console.WriteLine("On time");
        }
        else
        {
            Console.WriteLine("Late");
        }

        if (differenceInMinutes != 0)
        {
            var hours = Math.Abs(differenceInMinutes / 60);
            var minutes = Math.Abs(differenceInMinutes % 60);
            if (hours > 0)
            {
                if (minutes < 10)
                    Console.Write(hours + ":0" + minutes + " hours");
                else
                    Console.Write(hours + ":" + minutes + " hours");
            }
            else
            {
                Console.Write(minutes + " minutes");
            }
            if (differenceInMinutes < 0)
            {
                Console.WriteLine(" before the start");
            }
            else
            {
                Console.WriteLine(" after the start");
            }
        }
    }
}

