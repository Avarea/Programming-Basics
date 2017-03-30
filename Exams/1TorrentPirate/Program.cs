using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        double totalData = double.Parse(Console.ReadLine());
        int singleTicketPrice = int.Parse(Console.ReadLine());
        int wifeSpending = int.Parse(Console.ReadLine());

        double downloadingTime = totalData / 2 / 60 / 60;
        double priceForDownload = downloadingTime * wifeSpending;
        double movies = totalData / 1500;
        double ticketTotalPrice = singleTicketPrice * movies;

        if (priceForDownload > ticketTotalPrice)
        {
            Console.WriteLine("cinema -> {0:f2}lv", ticketTotalPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:f2}lv", priceForDownload);
        }

    }
}

