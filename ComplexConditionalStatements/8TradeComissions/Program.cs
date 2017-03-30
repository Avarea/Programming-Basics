using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string town = Console.ReadLine().ToLower();
        double value = double.Parse(Console.ReadLine());

        if (town == "sofia")
        {
            if (0 <= value && value <= 500)
            {
                Console.WriteLine("{0:f2}", value * 0.05);
            }
            else if (500 < value && value <= 1000)
            {
                Console.WriteLine("{0:f2}", value * 0.07);
            }
            else if (1000 < value && value <= 10000)
            {
                Console.WriteLine("{0:f2}", value * 0.08);
            }
            else if (10000 < value )
            {
                Console.WriteLine("{0:f2}", value *0.12);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (town == "varna")
        {
            if (0 <= value && value <= 500)
            {
                Console.WriteLine("{0:f2}", value * 0.045);
            }
            else if (500 < value && value <= 1000)
            {
                Console.WriteLine("{0:f2}", value * 0.075);
            }
            else if (1000 < value && value <= 10000)
            {
                Console.WriteLine("{0:f2}", value * 0.10);
            }
            else if (10000 < value)
            {
                Console.WriteLine("{0:f2}", value * 0.13);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (town == "plovdiv")
        {
            if (0 <= value && value <= 500)
            {
                Console.WriteLine("{0:f2}", value * 0.055);
            }
            else if (500 < value && value <= 1000)
            {
                Console.WriteLine("{0:f2}", value * 0.08);
            }
            else if (1000 < value && value <= 10000)
            {
                Console.WriteLine("{0:f2}", value * 0.12);
            }
            else if (10000 < value)
            {
                Console.WriteLine("{0:f2}", value * 0.145);
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

