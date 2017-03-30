using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 6 March 2016

class Program
{
    static void Main()
    {

        double height = double.Parse(Console.ReadLine()) * 100;
        double weight = double.Parse(Console.ReadLine()) * 100;

        double weightBura = Math.Truncate((weight - 100) / 70);
        double heightBura = Math.Truncate(height / 120);

        double totalBura = weightBura * heightBura - 3;
        Console.WriteLine(totalBura);
    }
}

