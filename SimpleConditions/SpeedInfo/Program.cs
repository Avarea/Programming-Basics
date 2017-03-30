using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която въвежда скорост             //(десетично число) и отпечатва информация за скоростта.
            //    При скорост до 10(включително) отпечатайте “slow”. 
            //При скорост над 10 и до 50 отпечатайте “average”. 
            //При скорост над 50 и до 150 отпечатайте “fast”.
            //При скорост над 150 и до 1000 отпечатайте “ultra fast”. 
            //    При по-висока скорост отпечатайте “extremely fast”.


            double speed = double.Parse(Console.ReadLine());
            if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
            else if (150 < speed && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (50 < speed && speed <=150)
            {
                Console.WriteLine("fast");
            }
            else if (10 < speed && speed <=50)
            {
                Console.WriteLine("average");
            }
            else
            {
                Console.WriteLine("slow");
            }

        }
    }
}
