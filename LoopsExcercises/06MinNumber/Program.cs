using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = int.Parse(Console.ReadLine());
            int firstnumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < entry - 1; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < firstnumber)
                {
                    firstnumber = number;
                }
            }
            Console.WriteLine(firstnumber);
        }
    }
}
