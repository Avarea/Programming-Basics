using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 26 March 2016


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool magic;

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            for (int b = 1; b <= 9; b++)
                            {
                                if (i * j * k * l * m * b == n)
                                {
                                    magic = true;
                                    Console.Write("{0}{1}{2}{3}{4}{5} ", i, j, k, l, m, b);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
