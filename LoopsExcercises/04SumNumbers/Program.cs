using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < entry; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
