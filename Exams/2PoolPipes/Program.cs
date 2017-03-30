﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 26 March 2016

class Program
{
    static void Main()
    {
        int V = int.Parse(Console.ReadLine());
        int pipe1 = int.Parse(Console.ReadLine());
        int pipe2 = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());
        double totalWater = (pipe1 + pipe2) * hours;

        if (V >= totalWater)
        {
            double pipe1Percent = pipe1 * hours / totalWater * 100;
            double pipe2Percent = pipe2 * hours / totalWater * 100;
            Console.WriteLine($"The pool is {Math.Truncate((totalWater / V) * 100)}% full. Pipe 1: {Math.Truncate(pipe1Percent)}%. Pipe 2: {Math.Truncate(pipe2Percent)}%.");
        }
        else
        {
            Console.WriteLine($"For {hours} hours the pool overflows with {Math.Abs(V - totalWater)} liters.");
        }
    }
}

