using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 26 March 2016

class Program
{
    static void Main()
    {
        double vegetablesPrice = double.Parse(Console.ReadLine());
        double fruitsPrice = double.Parse(Console.ReadLine());
        int vegetables = int.Parse(Console.ReadLine());
        int fruits = int.Parse(Console.ReadLine());

        double totalPrice = (vegetables * vegetablesPrice) + (fruits * fruitsPrice);
        Console.WriteLine(totalPrice / 1.94);

    }
}

