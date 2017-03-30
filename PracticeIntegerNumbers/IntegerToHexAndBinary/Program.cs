using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine().ToUpper());
            var hexValue = number.ToString("X");
            var binValue = Convert.ToString(number, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binValue);
        }
    }
}
