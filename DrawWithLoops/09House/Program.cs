using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstStars = 1;
            if (n % 2 == 0)
            {
                firstStars = 2;
            }
            for (int i = 0; i < (n+1)/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (n - firstStars) / 2), new string('*', firstStars));
                firstStars +=2;
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n-2));
            }

        }
    }
}
