using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 24 April 2016


class Program
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        int presentPrice = int.Parse(Console.ReadLine());

        var savings = 0;
        var moneyFromPresents = 0;
        var bonus = 10;


        for (int i = 1; i <= age; i++)
        {
            if (i % 2==0)
            {
                savings += bonus;
                savings -= 1;
                bonus += 10;
            }
            else
            {
                moneyFromPresents += presentPrice;
            }
        }
        var allMoney = savings + moneyFromPresents;
        if (allMoney >= washingMachinePrice)
        {
            Console.WriteLine("Yes! {0:f2}", allMoney - washingMachinePrice);
        }
        else
        {
            Console.WriteLine("No! {0:f2}", washingMachinePrice - allMoney);
        }
    }
}

