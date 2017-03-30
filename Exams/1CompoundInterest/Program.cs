using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Programs
{
    static void Main()
    {
        double tvPrice = double.Parse(Console.ReadLine());
        int yearsToPayBack = int.Parse(Console.ReadLine());
        double interestRate = double.Parse(Console.ReadLine());
        double friendPercent = double.Parse(Console.ReadLine());

        double totalBank = tvPrice * (Math.Pow(1 + interestRate,yearsToPayBack));
        double totalFriend = tvPrice * (1 + friendPercent);

        if (totalBank > totalFriend)
        {
            Console.WriteLine("{0:f2} Friend", totalFriend);
        }
        else
        {
            Console.WriteLine("{0:f2} Bank", totalBank);
        }
    }
}

