using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Основи на програмирането" – 20 ноември 2016

class Program
{
    static void Main()
    {
        int firstPlayer = int.Parse(Console.ReadLine());
        int secondPlayer = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 1; i <= firstPlayer; i++)
        {
            for (int j = 1; j <= secondPlayer; j++)
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

