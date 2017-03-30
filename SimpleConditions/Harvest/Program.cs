using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapePerkvmeter = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrape = area * grapePerkvmeter;
            double wine = totalGrape *0.4/2.5;

            if (wine >= neededWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Truncate(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - neededWine),Math.Ceiling((wine - neededWine)/workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Truncate(Math.Abs(wine - neededWine)));
            }

        }
    }
}
