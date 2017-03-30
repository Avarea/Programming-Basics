using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 19 March 2017 - Evening


class Problem6
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int control = int.Parse(Console.ReadLine());
        int combinations = 0;
        int result = 0;


        for (int i = 1; i <= n; i++)
        {
            for (int j = m; j >= 1; j--)
            {
                if (result > control)
                {
                    continue;
                }

                result += (i * 2) + (j * 3);
                combinations++;

            }
        }
        if (result > control)
        {
            Console.WriteLine("{0} moves", combinations);
            Console.WriteLine("Score: {0} >= {1}", result, control);
        }
        else
        {
            Console.WriteLine("{0} moves", combinations);
        }


    }
}

