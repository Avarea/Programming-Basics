using System;

//Programming Basics Exam - 20 November 2016 - Evening

class Program
{
    static void Main()
    {
        double smallRoomArea = double.Parse(Console.ReadLine());
        double kitchenArea = double.Parse(Console.ReadLine());
        double priceSquareMeter = double.Parse(Console.ReadLine());

        double secondRoomArea = smallRoomArea + (smallRoomArea * 0.1);
        double thirdRoomArea = secondRoomArea + (secondRoomArea * 0.1);
        double bathroomArea = smallRoomArea / 2;
        double houseArea = smallRoomArea + kitchenArea + secondRoomArea + thirdRoomArea + bathroomArea;
        double houseTotal = houseArea + (houseArea * 0.05);
        Console.WriteLine("{0:f2}", houseTotal * priceSquareMeter);

    }
}

