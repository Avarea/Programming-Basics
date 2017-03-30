using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        double moneyHave = double.Parse(Console.ReadLine());
        double alcoholWanted = double.Parse(Console.ReadLine());

        double boughtAlcohol = 0;
        string status = string.Empty;

        switch (dayOfWeek)
        {
            case 0:
                boughtAlcohol = moneyHave / 25;
                break;
            case 1:
                boughtAlcohol = moneyHave / 21;
                break;
            case 2:
                boughtAlcohol = moneyHave / 14;
                break;
            case 3:
                boughtAlcohol = moneyHave / 17;
                break;
            case 4:
                boughtAlcohol = moneyHave / 45;
                break;
            case 5:
                boughtAlcohol = moneyHave / 59;
                break;
            case 6:
                boughtAlcohol = moneyHave / 42;
                break;
            default:
                break;
        }

        if (boughtAlcohol > 1.5)
        {
            status = "very drunk";
        }
        else if (boughtAlcohol >= 1)
        {
            status = "drunk";
        }
        else
        {
            status = "sober";
        }

        if (alcoholWanted < boughtAlcohol)
        {
            Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:f2} l. of alcohol with his friends", status, boughtAlcohol - alcoholWanted);
        }
        else if (alcoholWanted == boughtAlcohol)
        {
            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", status);
        }
        else
        {
            Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:f2} l. of alcohol", status, Math.Abs(boughtAlcohol - alcoholWanted));
        }
    }
}

