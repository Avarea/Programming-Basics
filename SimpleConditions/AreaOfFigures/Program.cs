using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((side*side),3));
            }
            if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((side1*side2),3));
            }

            if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((Math.Pow(radius,2) * Math.PI),3));
            }
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((side * height/2), 3));
            }
        }
    }
}
