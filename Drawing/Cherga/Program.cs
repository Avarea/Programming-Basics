using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(new string('-', i));W
                }
                else
                {
                    Console.WriteLine(new string('*', i));
                }
            }
        }
    }
}
