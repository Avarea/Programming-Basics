using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());
        int combonations = 0;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            for (int j = firstNumber; j <= secondNumber; j++)
            {
                combonations++;
                if (i + j == magicNumber)
                {
                    Console.WriteLine($"Combination N: {combonations} ({i} + {j} = {magicNumber})");
                    return;
                }
            }
        }
        //this way you can calculate how many combinations you have
        //Note that you could find the number of combinations by counting with another variable (look at the variable "combinations")
        //So the commented code below would work correctly
        //Console.WriteLine($"{combonations} combinations - neither equals {magicNumber}");
        int diff = secondNumber - firstNumber + 1;
        Console.WriteLine($"{diff * diff} combinations - neither equals {magicNumber}");
    }
}