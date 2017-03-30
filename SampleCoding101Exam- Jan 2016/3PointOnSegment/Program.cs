using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int point = int.Parse(Console.ReadLine());

        int firstPoint = first - point; 
        int secondPoint = second - point; 

        if (first > point || point < second)
        {
            if (firstPoint > secondPoint)
            {
                Console.WriteLine("out");
                Console.WriteLine(second-point);
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(first-point);
            }
        }
        else if (firstPoint <= point || point <= secondPoint)
        {
            if (firstPoint > secondPoint)
            {
                Console.WriteLine("in");
                Console.WriteLine(second-point);
            }
            else
            {
                Console.WriteLine("in");
                Console.WriteLine(first-point);
            }
        }
    }
}

