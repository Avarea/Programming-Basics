using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if ((number < 100 || 200 < number) && number !=0)
        {
            Console.WriteLine("invalid");
        }
    }
}

