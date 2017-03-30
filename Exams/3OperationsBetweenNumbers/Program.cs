using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 24 April 2016

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        string operatorNeeded = Console.ReadLine();
        double result = 0;

        if (operatorNeeded == "+")
        {
            result = num1 + num2;
            if (result % 2== 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", num1, operatorNeeded, num2, result);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3} - odd", num1, operatorNeeded, num2, result);
            }
        }
        else if (operatorNeeded == "-")
        {
            result = num1 - num2;
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", num1, operatorNeeded, num2, result);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3} - odd", num1, operatorNeeded, num2, result);
            }
        }
        else if (operatorNeeded == "*")
        {
            result = num1 * num2;
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", num1, operatorNeeded, num2, result);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3} - odd", num1, operatorNeeded, num2, result);
            }
        }
        else if (operatorNeeded == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", num1);
            }
            else
            {
                result = (double)num1 / num2;
                Console.WriteLine("{0} / {1} = {2:f2}", num1, num2, result);
            }
        }
        else if (operatorNeeded == "%")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", num1);
            }
            else
            {
                result = num1 % num2;
                Console.WriteLine("{0} % {1} = {2}", num1, num2, result);
            }
        }

    }
}

