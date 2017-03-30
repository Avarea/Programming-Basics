﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 24 April 2016

class Program
{
    static void Main()
    {
        int daysOff = int.Parse(Console.ReadLine());
        int norm = 30000;
        int playingInWorkingDays = (365 - daysOff) * 63;
        int playingDaysOff = daysOff * 127;
        int totalPlaying = playingDaysOff + playingInWorkingDays;

        if (totalPlaying > norm)
        {
            int diff = Math.Abs(norm - totalPlaying);
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", diff / 60, diff % 60);
        }
        else
        {
            int diff = Math.Abs(norm - totalPlaying);
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", diff / 60, diff % 60);
        }

    }
}

