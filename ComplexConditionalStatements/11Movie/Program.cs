using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "Premiere":
                Console.WriteLine("{0:f2} leva", (rows * cows) * 12.00);
                break;
            case "Normal":
                Console.WriteLine("{0:f2} leva", (rows * cows) * 7.50);
                break;
            case "Discount":
                Console.WriteLine("{0:f2} leva", (rows * cows) * 5.00);
                break;
            default:
                break;
        }
    }
}

