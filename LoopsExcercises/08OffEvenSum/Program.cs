using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08OffEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            int diff = Math.Abs(evenSum - oddSum);
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes Sum = {0}", evenSum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", diff);
            }
        }
    }
}
