using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 19 March 2017 - Evening


class Problem4
{
    static void Main()
    {
        int months = int.Parse(Console.ReadLine());

        double electricityTotal = 0;
        double waterBill = months * 20;
        double internetBill = months * 15;


        for (int i = 1; i <= months; i++)
        {
            double electricityPerMonth = double.Parse(Console.ReadLine());
            electricityTotal += electricityPerMonth;
        }
        double totalBills = electricityTotal + waterBill + internetBill;
        double otherBills = (totalBills * 0.2) + totalBills;
        Console.WriteLine("Electricity: {0:f2} lv", electricityTotal);
        Console.WriteLine("Water: {0:f2} lv", waterBill);
        Console.WriteLine("Internet: {0:f2} lv", internetBill);
        Console.WriteLine("Other: {0:f2} lv", otherBills);
        Console.WriteLine("Average: {0:f2} lv", (totalBills + otherBills)/ months);
    }
}





