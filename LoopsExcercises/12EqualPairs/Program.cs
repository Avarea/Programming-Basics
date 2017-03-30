using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        int maxDiff = 0;
        for (int i = 0; i < n; i++)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            array[i] = sum;
        }

        for (int i = 1; i < n; i++)
        {
            int diff = Math.Abs(array[i] - array[i - 1]);
            if (diff > maxDiff)
            {
                maxDiff = diff;
            }
        }
        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", array[0]);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}