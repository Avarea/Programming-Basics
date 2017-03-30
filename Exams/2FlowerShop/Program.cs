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
        int magnolii = int.Parse(Console.ReadLine());
        int zumbuli = int.Parse(Console.ReadLine());
        int rosi = int.Parse(Console.ReadLine());
        int kaktusi = int.Parse(Console.ReadLine());
        double giftPrice = double.Parse(Console.ReadLine());

        double flowerCost = (magnolii * 3.25) + (zumbuli * 4) + (rosi * 3.5) + (kaktusi * 8);
        double afterTaxes = flowerCost - (flowerCost * 0.05);

        if (afterTaxes < giftPrice)
        {
            Console.WriteLine("She will have to borrow {0} leva.", Math.Abs(Math.Floor(afterTaxes - giftPrice)));
        }
        else
        {
            Console.WriteLine("She is left with {0} leva.", Math.Abs(Math.Ceiling(giftPrice - afterTaxes)));
        }
    }
}

