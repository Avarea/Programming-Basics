using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double workingHours = (days -(days * 0.10)) * 8;
            double overtimeHours = workers * (2 * days);
            double totalHours = workingHours + overtimeHours;
            if (totalHours >= neededHours)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Truncate(Math.Abs(totalHours - neededHours)));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(Math.Abs(totalHours - neededHours)));
            }
        }
    }
}
