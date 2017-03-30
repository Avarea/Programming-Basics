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
        int lectures = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        int jelev = 0;
        int royal = 0;
        int roli = 0;
        int trofon = 0;
        int sino = 0;
        int others = 0;


        for (int i = 1; i <= lectures; i++)
        {
            string trainer = Console.ReadLine();
            switch (trainer)
            {
                case "Jelev":
                    jelev++;
                    break;
                case "RoYaL":
                    royal++;
                    break;
                case "Roli":
                    roli++;
                    break;
                case "Trofon":
                    trofon++;
                    break;
                case "Sino":
                    sino++;
                    break;
                default:
                    others++;
                    break;
            }
        }

        Console.WriteLine("Jelev salary: {0:f2} lv", budget / lectures * jelev);
        Console.WriteLine("RoYaL salary: {0:f2} lv", budget / lectures * royal);
        Console.WriteLine("Roli salary: {0:f2} lv", budget / lectures * roli);
        Console.WriteLine("Trofon salary: {0:f2} lv", budget / lectures * trofon);
        Console.WriteLine("Sino salary: {0:f2} lv", budget / lectures * sino);
        Console.WriteLine("Others salary: {0:f2} lv", budget / lectures * others);
    }
}

