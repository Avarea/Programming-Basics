using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int botRectXStart = 0;
        int botRectXFinish = 3 * h;
        int botRectYStart = 0;
        int botRectYFinish = h;

        int topRectXStart = h;
        int topRectXFinish = 2 * h;
        int topRectYStart = h;
        int topRectYFinish = 4 * h;

        int isInBotRect = -2;
        int isInTopRect = -2;

        bool onMiddleLine = x < h || x > 2 * h;

        if ((x >= botRectXStart && x <= botRectXFinish) && (y >= botRectYStart && y <= botRectYFinish))
        {
            if ((x == botRectXStart || x == botRectXFinish) || (y == botRectYStart || (y == botRectYFinish && onMiddleLine)))
            {
                isInBotRect = 0;
            }
            else
            {
                isInBotRect = 1;
            }
        }
        else
        {
            isInBotRect = -1;
        }

        if ((x >= topRectXStart && x <= topRectXFinish) && (y >= topRectYStart && y <= topRectYFinish))
        {
            if ((x == topRectXStart || x == topRectXFinish) || (y == topRectYStart || (y == topRectYFinish && onMiddleLine)))
            {
                isInTopRect = 0;
            }
            else
            {
                isInTopRect = 1;
            }
        }
        else
        {
            isInTopRect = -1;
        }

        if (isInBotRect == -1 && isInTopRect == -1)
        {
            Console.WriteLine("outside");
        }
        else if (isInBotRect == 0 || isInTopRect == 0)
        {
            Console.WriteLine("border");
        }
        else
        {
            Console.WriteLine("inside");
        }
    }
}

