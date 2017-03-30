using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string fruit = Console.ReadLine();
        string day = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        if (day == "Saturday" || day == "Sunday")
        {
            if (fruit == "banana")
            {
                Console.WriteLine("{0:f2}", quantity * 2.7);
            }
            else if (fruit == "apple")
            {
                Console.WriteLine("{0:f2}", quantity * 1.25);
            }
            else if (fruit == "orange")
            {
                Console.WriteLine("{0:f2}", quantity * 0.90);
            }
            else if (fruit == "grapefruit")
            {
                Console.WriteLine("{0:f2}", quantity * 1.6);
            }
            else if (fruit == "kiwi")
            {
                Console.WriteLine("{0:f2}", quantity * 3.00);
            }
            else if (fruit == "pineapple")
            {
                Console.WriteLine("{0:f2}", quantity * 5.6);
            }
            else if (fruit == "grapes")
            {
                Console.WriteLine("{0:f2}", quantity * 4.2);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
        {
            if (fruit == "banana")
            {
                Console.WriteLine("{0:f2}", quantity * 2.5);
            }
            else if (fruit == "apple")
            {
                Console.WriteLine("{0:f2}", quantity * 1.20);
            }
            else if (fruit == "orange")
            {
                Console.WriteLine("{0:f2}", quantity * 0.85);
            }
            else if (fruit == "grapefruit")
            {
                Console.WriteLine("{0:f2}", quantity * 1.45);
            }
            else if (fruit == "kiwi")
            {
                Console.WriteLine("{0:f2}", quantity * 2.70);
            }
            else if (fruit == "pineapple")
            {
                Console.WriteLine("{0:f2}", quantity * 5.5);
            }
            else if (fruit == "grapes")
            {
                Console.WriteLine("{0:f2}", quantity * 3.85);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
