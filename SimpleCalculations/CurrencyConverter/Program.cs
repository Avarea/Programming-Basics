using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            var incoming = Console.ReadLine().ToLower();
            var outgoing = Console.ReadLine().ToLower();

            if (incoming == "bgn")
            {
                if (outgoing == "eur")
                {
                    Console.WriteLine("{0} EUR", Math.Round(amount / 1.95583, 2));
                }
                else if (outgoing == "usd")
                {
                    Console.WriteLine("{0} USD", Math.Round(amount / 1.79549, 2));
                }
                else if (outgoing == "gbp")
                {
                    Console.WriteLine("{0} GBP", Math.Round(amount / 2.53405, 2));
                }
            }


            if (incoming == "eur")
            {
                if (outgoing == "bgn")
                {
                    Console.WriteLine("{0} BGN", Math.Round(amount * 1.95583, 2));
                }
                else if (outgoing == "usd")
                {
                    Console.WriteLine("{0} USD", Math.Round(amount * 1.08930, 2));
                }
                else if (outgoing == "gbp")
                {
                    Console.WriteLine("{0} GBP", Math.Round(amount * 0.77181, 2));
                }
            }


            if (incoming == "usd")
            {
                if (outgoing == "bgn")
                {
                    Console.WriteLine("{0} BGN", Math.Round(amount * 1.79549, 2));
                }
                else if (outgoing == "eur")
                {
                    Console.WriteLine("{0} EUR", Math.Round(amount * 0.91801, 2));
                }
                else if (outgoing == "gbp")
                {
                    Console.WriteLine("{0} GBP", Math.Round(amount * 0.70854, 2));
                }
            }

            if (incoming == "gbp")
            {
                if (outgoing == "bgn")
                {
                    Console.WriteLine("{0} BGN", Math.Round(amount / 2.53405, 2));
                }
                else if (outgoing == "eur")
                {
                    Console.WriteLine("{0} EUR", Math.Round(amount / 1.29563, 2));
                }
                else if (outgoing == "usd")
                {
                    Console.WriteLine("{0} USD", Math.Round(amount / 0.70854, 2));
                }
            }
        }
    }
}
