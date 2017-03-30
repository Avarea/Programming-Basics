using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 28 August 2016


class Program
{
    static void Main(string[] args)
    {
        int period = int.Parse(Console.ReadLine());
        int countpatients = 0;
        int waiting = 0;
        int countwaiting = 0;
        int examed = 0;
        int countexamed = 0;
        int numberdoctors = 7;
        for (int i = 1; i <= period; i++)
        {
            int numberpatients = int.Parse(Console.ReadLine());
            if (i % 3 == 0 && countexamed < countwaiting)
            {
                numberdoctors++;
            }
            countpatients += numberpatients;
            if (numberdoctors <= numberpatients)
            {
                examed = numberdoctors;
                waiting = numberpatients - numberdoctors;

            }
            if (numberdoctors > numberpatients)
            {
                examed = numberpatients;
            }
            countexamed += examed;
            countwaiting = countpatients - countexamed;


        }
        Console.WriteLine("Treated patients: {0}.", countexamed);
        Console.WriteLine("Untreated patients: {0}.", countwaiting);
    }
}
