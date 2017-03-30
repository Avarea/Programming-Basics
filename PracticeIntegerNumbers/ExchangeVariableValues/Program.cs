using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int temp = 5;
            num1 = 10;
            num2 = temp;

            Console.WriteLine("Before:");
            Console.WriteLine("a = 5");
            Console.WriteLine("b = 10");
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", num1);
            Console.WriteLine("b = {0}", num2);

        }
    }
}
