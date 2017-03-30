using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            DateTime input = DateTime.ParseExact(month, day);
            Console.WriteLine(input.AddDays(5).ToShortDateString());

        }
    }
}
