using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            double bonus = 0;


            if (score > 1000)
            {
                bonus = 10 * score / 100;
            }
            else if (score > 100)
            {
                bonus = 20 * score / 100;
            }
            else
            {
                bonus = 5;
            }

            double totalBonus = bonus;

            if (score % 2 == 0)
            {
                 totalBonus = bonus + 1; 
            }
            else if (score % 10 == 5)
            {
                 totalBonus = bonus + 2;
            }

            Console.WriteLine(totalBonus);
            Console.WriteLine(totalBonus + score);
        }
    }
}
