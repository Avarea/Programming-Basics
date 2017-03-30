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


            if (incoming == "usd")
            {
                if (outgoing == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(amount * 1.79549, 2));   //ok
                }
                else if (outgoing == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(amount * 0.91801, 2));   //ok
                }
                else if (outgoing == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(amount * 0.70854, 2));  //ok
                }

            }

            if (incoming == "bgn")
            {
                if (outgoing == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(amount /1.79549, 2)); //ok
                }
                else if (outgoing == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(amount/1.95583, 2));  //ok
                }
                else if (outgoing == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(amount/2.53405, 2));  //ok
                }
            }

            if (incoming == "eur")
            {
                if (outgoing == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(amount * 1.95583, 2)); //ok
                }
                else if (outgoing == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(amount * 1.08930, 2)); //ok
                }
                else if (outgoing == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(amount * 0.77181, 2)); //ok
                }
            }
            if (incoming == "gbp")
            {
                if (outgoing == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(amount* 2.53405, 2)); //ok
                }
                else if (outgoing == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(amount*0.77181, 2)); //ok
                }
                else if (outgoing == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(amount * 1.41134, 2)); //ok
                }
            }

        }
    }
}


