using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());

            int secs = sec1 + sec2 + sec3;
            int mins = 0;

            if (secs > 59)
            {
                mins++;
                secs = secs - 60;
            }
            if (secs > 59)
            {
                mins++;
                secs = secs - 60;
            }
            if (secs > 59)
            {
                mins++;
                secs = secs - 60;
            }

            if (secs < 10)
            {
                Console.WriteLine("{0}:0{1}", mins, secs);
            }
            else
            {
                Console.WriteLine("{0}:{1}", mins, secs);
            }
        }
    }
}
