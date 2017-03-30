using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 18 December 2016

class Program
{
    static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char thirdLetter = char.Parse(Console.ReadLine());
        int counter = 0;
        for (char i = firstLetter; i <= secondLetter; i++)
        {
            if (i == thirdLetter)
            {
                continue;
            }
            for (char j = firstLetter; j <= secondLetter; j++)
            {
                if (j == thirdLetter)
                {
                    continue;
                }
                for (char k = firstLetter; k <= secondLetter; k++)
                {
                    if (k == thirdLetter)
                    {
                        continue;
                    }
                    Console.Write("{0}{1}{2} ",i,j,k);
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}

