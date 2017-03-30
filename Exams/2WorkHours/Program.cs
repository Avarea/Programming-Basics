using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Основи на програмирането" – 18 март 2017

class Program
{
    static void Main()
    {
        int neededHours = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int workingDays = int.Parse(Console.ReadLine());

        int hoursTotal = workers * workingDays * 8;

        if (hoursTotal >= neededHours)
        {
            Console.WriteLine("{0} hours left", Math.Abs(neededHours - hoursTotal));
        }
        else
        {
            Console.WriteLine("{0} overtime", Math.Abs(neededHours - hoursTotal));
            Console.WriteLine("Penalties: {0}", Math.Abs(neededHours - hoursTotal) * workingDays);
        }

    }
}

