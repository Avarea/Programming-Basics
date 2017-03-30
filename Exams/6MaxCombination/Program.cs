using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 20 November 2016 - Evening

class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = first; i <= second; i++)
        {
            for (int j = first; j <= second; j++)
            {
                Console.Write("<{0}-{1}>", i, j);
                counter++;
                if (counter == max)
                {
                    return;
                }
            }
        }

    }
}
