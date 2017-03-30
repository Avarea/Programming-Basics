using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Основи на програмирането" – 19 март 2017 сутрин


class Program
{
    static void Main()
    {
        double househeight = double.Parse(Console.ReadLine());
        double sideHeight = double.Parse(Console.ReadLine());
        double roofHeight = double.Parse(Console.ReadLine());

        double sideArea = househeight * sideHeight;
        double window = 1.5 * 1.5;
        double bothSideAreas = 2 * sideArea - 2 * window;
        double backArea = househeight * househeight;
        double door = 1.2 * 2;
        double frontAndBackArea = 2 * backArea - door;
        double totalHouseArea = frontAndBackArea + bothSideAreas;

        double sidesRoof = 2 * househeight * sideHeight;
        double triangleRoof = 2 * (househeight * roofHeight / 2);

        double totalRoofArea = sidesRoof + triangleRoof;

        Console.WriteLine("{0:f2}", totalHouseArea / 3.4);
        Console.WriteLine("{0:f2}", totalRoofArea / 4.3);
    }
}

