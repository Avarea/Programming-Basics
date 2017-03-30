using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Основи на програмирането" – 19 март 2017 сутрин

class Program
{
    static void Main()
    {
        int cupsNeeded = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int workingDays = int.Parse(Console.ReadLine());

        int totalWorkingHours = workers * workingDays * 8;
        int cupsMade = totalWorkingHours / 5;

        double money = Math.Abs(cupsMade - cupsNeeded) * 4.2;

        if (cupsNeeded <= cupsMade)
        {
            Console.WriteLine("{0:f2} extra money", money);
        }
        else
        {
            Console.WriteLine("Losses: {0:f2}", money);
        }
    }
}

