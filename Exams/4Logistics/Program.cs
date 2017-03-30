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
        int cargoCount = int.Parse(Console.ReadLine());
        double mikrobusCargo = 0;
        double kamionCargo = 0;
        double vlakCargo = 0;
        int price = 0;
        int cargo = 0;

        for (int i = 1; i <= cargoCount; i++)
        {
            int cargoWeight = int.Parse(Console.ReadLine());
            if (cargoWeight <= 3)
            {
                price += cargoWeight * 200;
                cargo += cargoWeight;
                mikrobusCargo += cargoWeight;
            }
            else if (cargoWeight <= 11)
            {
                price += cargoWeight * 175;
                cargo += cargoWeight;
                kamionCargo += cargoWeight;
            }
            else
            {
                price += cargoWeight * 120;
                cargo += cargoWeight;
                vlakCargo += cargoWeight;
            }

        }
        double totalPrice = price;
        Console.WriteLine("{0:f2}", totalPrice / cargo);
        Console.WriteLine("{0:f2}%", mikrobusCargo / cargo *100);
        Console.WriteLine("{0:f2}%", kamionCargo / cargo * 100);
        Console.WriteLine("{0:f2}%", vlakCargo / cargo * 100);
    }
}

