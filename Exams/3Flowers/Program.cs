using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 18 December 2016


class Program
{
    static void Main()
    {
        int hrizantemi = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int laleta = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string holiday = Console.ReadLine();

        double hrizantemaPriceSpringSummer = 2.00;
        double hrizantemaPriceAutumnWinter = 3.75;
        double rosePriceSpringSummer = 4.10;
        double rosePriceAutumnWinter = 4.50;
        double lalePriceSpringSummer = 2.50;
        double lalePriceAutumnWinter = 4.15;
        double aranjirovkaPrice = 2.00;
        int flowers = hrizantemi + roses + laleta;


        double priceOfFlowersSpringSummer = (hrizantemaPriceSpringSummer * hrizantemi) + (rosePriceSpringSummer * roses) + (lalePriceSpringSummer * laleta);
        double totalPriceSpringSummer = priceOfFlowersSpringSummer;



        if (season == "Spring" || season == "Summer")
        {
            if (holiday == "Y")
            {
                priceOfFlowersSpringSummer = priceOfFlowersSpringSummer + (priceOfFlowersSpringSummer * 0.15);
                if (laleta > 7)
                {
                    if (season == "Spring")
                    {
                        priceOfFlowersSpringSummer = priceOfFlowersSpringSummer - (priceOfFlowersSpringSummer * 0.05);
                    }
                }
                if (flowers > 20)
                {
                    priceOfFlowersSpringSummer = priceOfFlowersSpringSummer - (priceOfFlowersSpringSummer * 0.2);
                }
            }
            else
            {
                if (laleta > 7)
                {
                    if (season == "Spring")
                    {
                        priceOfFlowersSpringSummer = priceOfFlowersSpringSummer - (priceOfFlowersSpringSummer * 0.05);
                    }
                }
                if (flowers > 20)
                {
                    priceOfFlowersSpringSummer = priceOfFlowersSpringSummer - (priceOfFlowersSpringSummer * 0.2);
                }
            }
            Console.WriteLine("{0:f2}", priceOfFlowersSpringSummer + 2);
        }

        double priceOfFlowersAutumnWinter = (hrizantemaPriceAutumnWinter * hrizantemi) + (rosePriceAutumnWinter * roses) + (lalePriceAutumnWinter * laleta);
        double totalPriceAutumnWinter = priceOfFlowersAutumnWinter;

        if (season == "Autumn" || season == "Winter")
        {
            if (holiday == "Y")
            {
                priceOfFlowersAutumnWinter = priceOfFlowersAutumnWinter + (priceOfFlowersAutumnWinter * 0.15);
                if (roses > 10)
                {
                    if (season == "Winter")
                    {
                        priceOfFlowersAutumnWinter = priceOfFlowersAutumnWinter - (priceOfFlowersAutumnWinter * 0.1);
                    }
                }
                if (flowers > 20)
                {
                    priceOfFlowersAutumnWinter = priceOfFlowersAutumnWinter - (priceOfFlowersAutumnWinter * 0.2);
                }
            }
            else
            {
                if (roses >= 10)
                {
                    if (season == "Winter")
                    {
                        priceOfFlowersAutumnWinter = priceOfFlowersAutumnWinter - (priceOfFlowersAutumnWinter * 0.1);
                    }
                }
                if (flowers > 20)
                {
                    priceOfFlowersAutumnWinter = priceOfFlowersAutumnWinter - (priceOfFlowersAutumnWinter * 0.2);
                }
            }
            Console.WriteLine("{0:f2}", priceOfFlowersAutumnWinter + 2);
        }

    }
}

