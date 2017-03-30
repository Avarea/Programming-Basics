using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Coding 101 Exam - 24 April 2016

class Program
{
    static void Main()
    {
        int side = int.Parse(Console.ReadLine());
        double heightOfTile = double.Parse(Console.ReadLine());
        double weightOfTile = double.Parse(Console.ReadLine());
        int weightOfBench = int.Parse(Console.ReadLine());
        int sideOfBench = int.Parse(Console.ReadLine());

        double area = Math.Pow(side, 2);
        double benchArea = weightOfBench * sideOfBench;
        double areaWithoutBench = area - benchArea;
        double tileArea = heightOfTile * weightOfTile;
        double tilesNeeded = areaWithoutBench / tileArea;
        double time = tilesNeeded * 0.2;

        Console.WriteLine(tilesNeeded);
        Console.WriteLine(time);

    }
}

