using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 20 November 2016 - Morning

class Program
{
    static void Main()
    {
        double skumriqPrice = double.Parse(Console.ReadLine());
        double cacaPrice = double.Parse(Console.ReadLine());
        double kilogramsPalamud = double.Parse(Console.ReadLine());
        double kilogramsSafrid = double.Parse(Console.ReadLine());
        int kilogramsMidi = int.Parse(Console.ReadLine());

        double palamudPrice = skumriqPrice + (skumriqPrice * 0.60);
        double palamudTotal = palamudPrice * kilogramsPalamud;
        double safridPrice = cacaPrice + (cacaPrice * 0.8);
        double safridTotal = safridPrice * kilogramsSafrid;
        double midiTotal = kilogramsMidi * 7.5;

        double total = palamudTotal + safridTotal + midiTotal;
        Console.WriteLine("{0:f2}", total);

    }
}

