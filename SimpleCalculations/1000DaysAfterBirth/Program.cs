using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var birthDate = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            birthDate = birthDate.AddDays(999);
            Console.WriteLine(birthDate.ToString(format));
        }
    }
}
