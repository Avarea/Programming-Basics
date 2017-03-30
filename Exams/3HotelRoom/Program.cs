using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 28 August 2016

class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        int numberOfNights = int.Parse(Console.ReadLine());

        if (month == "May" || month == "October")
        {
            double studio = 50;
            double apartment = 65;
            if (numberOfNights > 14)
            {
                Console.WriteLine("Apartment: {0:f2} lv.", (apartment - (apartment *0.1)) * numberOfNights);
                Console.WriteLine("Studio: {0:f2} lv.", (studio - (studio * 0.3)) * numberOfNights);
            }
            else if (numberOfNights > 7)
            {
                Console.WriteLine("Apartment: {0:f2} lv.", (apartment * numberOfNights));
                Console.WriteLine("Studio: {0:f2} lv.", (studio - (studio * 0.05)) * numberOfNights);
            }
            else
            {
                Console.WriteLine("Apartment: {0:f2} lv.", (apartment * numberOfNights));
                Console.WriteLine("Studio: {0:f2} lv.", (studio * numberOfNights));
            }
        }

        if (month == "June" || month == "September")
        {
            double studio = 75.20;
            double apartment = 68.70;
            if (numberOfNights > 14)
            {
                Console.WriteLine("Apartment: {0:f2} lv.", (apartment - (apartment * 0.1)) * numberOfNights);
                Console.WriteLine("Studio: {0:f2} lv.", (studio - (studio * 0.2)) * numberOfNights);
            }
            else if (numberOfNights > 7)
            {
                Console.WriteLine("Apartment: {0:f2} lv.", (apartment * numberOfNights));
                Console.WriteLine("Studio: {0:f2} lv.", (studio  * numberOfNights));
            }
            else
            {
                Console.WriteLine("Apartment: {0:f2} lv.", (apartment * numberOfNights));
                Console.WriteLine("Studio: {0:f2} lv.", (studio * numberOfNights));
            }
        }

        if (month == "July" || month == "August")
        {
            double studio = 76;
            double apartment = 77;
            if (numberOfNights > 14)
            {
                Console.WriteLine("Apartment: {0:f2} lv.", (apartment - (apartment * 0.1)) * numberOfNights);
                Console.WriteLine("Studio: {0:f2} lv.", (studio  * numberOfNights));
            }
            else
            {
                Console.WriteLine("Apartment: {0:f2} lv.", (apartment * numberOfNights));
                Console.WriteLine("Studio: {0:f2} lv.", (studio * numberOfNights));
            }
        }
    }
}

