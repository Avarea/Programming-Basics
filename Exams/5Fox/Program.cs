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
        int tiretaUp = 2 * n - 1;
        int starsUp = 1;

        int fStarsMid = n / 2;
        int midStarsMid = n;

        int tiretaDown = 1;
        int starsDown = 2 * n - 1;
        //up
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('*',starsUp), new string('-',tiretaUp));
            starsUp++;
            tiretaUp = tiretaUp - 2;
        }
        //mid
        for (int i = 1; i <= n / 3; i++)
        {
            Console.WriteLine("|{0}\\{1}/{0}|", new string('*', fStarsMid), new string('*', midStarsMid));
            fStarsMid = fStarsMid + 1;
            midStarsMid = midStarsMid - 2;
        }
        //down
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('-', tiretaDown), new string('*', starsDown));
            starsDown = starsDown - 2;
            tiretaDown++;
        }
    }
}

