using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Основи на програмирането" – 18 март 2017

class Program
{
    static void Main()
    {
        double sideLenght = double.Parse(Console.ReadLine());
        double heightLenght = double.Parse(Console.ReadLine());

        double sideArea = sideLenght * sideLenght / 2 * 2;
        double backAreaSquare = (sideLenght / 2 * sideLenght / 2);
        double backAreaTriangle = (sideLenght / 2 * (heightLenght - sideLenght / 2)) / 2;
        double backArea = backAreaSquare +backAreaTriangle;
        double entranceArea = sideLenght / 5 * sideLenght / 5;
        double frontArea = backArea - entranceArea;
        double roofArea = sideLenght * sideLenght / 2 * 2;
        double totalArea = sideArea + backArea + frontArea;

        double greenPaint = totalArea / 3;
        double redPaint = roofArea / 5;


        Console.WriteLine("{0:f2}", greenPaint);
        Console.WriteLine("{0:f2}", redPaint);
    }
}

