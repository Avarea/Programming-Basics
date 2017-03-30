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
        int adults = int.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        string transport = Console.ReadLine();

        double adultsTrain = 24.99;
        double adultsBus = 32.50;
        double adultsBoat = 42.99;
        double adultsPlane = 70.00;
        double studentsTrain = 14.99;
        double studentsBus = 28.50;
        double studentsBoat = 39.99;
        double studentsPlane = 50.00;
        double priceForSleep = nights * 82.99;
        int totalTravelers = adults + students;
        double price = 0;


        if (transport == "train")
        {
            if (totalTravelers >= 50)
            {
                price = 2 *(((adults * adultsTrain) + (students * studentsTrain)) - ((((adults * adultsTrain) + (students * studentsTrain)) * 0.5)));
            }
            else
            {
                price = 2* ((adults * adultsTrain) + (students * studentsTrain));
            }
        }
        else if (transport == "bus")
        {
            price = 2 * ((adults * adultsBus) + (students * studentsBus));
        }
        else if (transport == "boat")
        {
            price = 2 * ((adults * adultsBoat) + (students * studentsBoat));
        }
        else
        {
            price = 2 * ((adults * adultsPlane) + (students * studentsPlane));

        }

        double totalPrice = price + priceForSleep;
        double afterCommision = totalPrice + (totalPrice * 0.10);
        Console.WriteLine("{0:f2}", afterCommision);
    }
}

