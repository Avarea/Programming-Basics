using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Основи на програмирането" – 18 март 2017

class Program
{
    static void Main()
    {
        int turns = int.Parse(Console.ReadLine());
        double result = 0;
        double first = 0;
        double second = 0;
        double third = 0;
        double forth = 0;
        double fifth = 0;
        double invalid = 0;

        for (int i = 1; i <= turns; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0 || number > 50)
            {
                result /= 2;
                invalid++;
            }
            else if (number >= 0 && number < 10)
            {
                result = result + number * 0.2;
                first++;
            }
            else if (number >= 10 && number < 20)
            {
                result = result + number * 0.3;
                second++;
            }
            else if (number >= 20 && number < 30)
            {
                result = result + number * 0.4;
                third++;
            }
            else if (number >= 30 && number < 40)
            {
                result += 50;
                forth++;
            }
            else
            {
                result += 100;
                fifth++;
            }
        }
        Console.WriteLine("{0:f2}", result);
        Console.WriteLine("From 0 to 9: {0:f2}%", first / turns * 100);
        Console.WriteLine("From 10 to 19: {0:f2}%", second / turns * 100);
        Console.WriteLine("From 20 to 29: {0:f2}%", third / turns * 100);
        Console.WriteLine("From 30 to 39: {0:f2}%", forth / turns * 100);
        Console.WriteLine("From 40 to 50: {0:f2}%", fifth / turns * 100);
        Console.WriteLine("Invalid numbers: {0:f2}%", invalid / turns * 100);
    }
}

