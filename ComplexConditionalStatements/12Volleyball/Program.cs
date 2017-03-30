using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weekend = int.Parse(Console.ReadLine());

        double playingWeekends = (48 - weekend) * 3.0/4;
        double playingHollidays = holidays * 2.0/3;

        double totalGames = playingHollidays + playingWeekends + weekend;

        switch (year)
        {
            case "leap":
                Console.WriteLine(Math.Truncate(totalGames + (totalGames *0.15)));
                break;
            default:
                Console.WriteLine(Math.Truncate(totalGames));
                break;
        }

    }
}

