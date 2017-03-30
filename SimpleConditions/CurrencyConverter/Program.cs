using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var inCurrency = Console.ReadLine();
            var outCurrency = Console.ReadLine();

            if (inCurrency == "USD")
            {
                num *= 1.79549;
            }
            else if (inCurrency == "EUR")
            {
                num *= 1.95583;
            }
            else if (inCurrency == "GBP")
            {
                num *= 2.53405;
            }



            if (outCurrency == "USD")
            {
                num /= 1.79549;
            }
            else if (outCurrency == "EUR")
            {
                num /= 1.95583;
            }
            else if (outCurrency == "GBP")
            {
                num /= 2.53405;
            }

            Console.WriteLine(Math.Round(num, 2) + " " + outCurrency);
        }
    }
}
