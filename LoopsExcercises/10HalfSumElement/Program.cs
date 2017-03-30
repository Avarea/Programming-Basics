using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNum)
                {
                    maxNum = number;
                }
                sum += number;

            }
            if ((sum - maxNum) == maxNum)
            {
                Console.WriteLine("Yes Sum = {0}", sum - maxNum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(maxNum - (sum-maxNum)));
            }
        }
    }
}
