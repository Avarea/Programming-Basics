using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());
            //Console.WriteLine(new string('*', n));
            //for (int i = 0; i < n -2; i++)
            //{
            //    Console.WriteLine("*" + new string(' ', n-2) + "*");
            //}
            //Console.WriteLine(new string('*', n));
            //======================================================
            var number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 0; i < number - 2; i++)
            {
                Console.WriteLine("*{0}*", new string(' ', number - 2));
            }


            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
