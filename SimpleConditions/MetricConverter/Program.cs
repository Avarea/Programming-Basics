using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {

//входна единица//изходна единица
//1 meter(m)//1000 millimeters(mm)
//1 meter(m)//100 centimeters(cm)
//1 meter(m)//0.000621371192 miles(mi)
//1 meter(m)//39.3700787 inches(in)
//1 meter(m)//0.001 kilometers(km)
//1 meter(m)//3.2808399 feet(ft)
//1 meter(m)//1.0936133 yards(yd)

            double num = double.Parse(Console.ReadLine());
            string inMetric = Console.ReadLine();
            string outMetric = Console.ReadLine();


            if (inMetric == "m")
            {
                num /= 1;
            }
            else if (inMetric == "mm")
            {
                num /= 1000;
            }
            else if (inMetric == "cm")
            {
                num /= 100;
            }
            else if (inMetric == "mi")
            {
                num /= 0.000621371192;
            }
            else if (inMetric == "in")
            {
                num /= 39.3700787;
            }
            else if (inMetric == "km")
            {
                num /= 0.001;
            }
            else if (inMetric == "ft")
            {
                num /= 3.2808399;
            }
            else if (inMetric == "yd")
            {
                num /= 1.0936133;
            }
            //////////////////////////
            if (outMetric == "m")
            {
                num *= 1;
            }
            else if (outMetric == "mm")
            {
                num *= 1000;
            }
            else if (outMetric == "cm")
            {
                num *= 100;
            }
            else if (outMetric == "mi")
            {
                num *= 0.000621371192;
            }
            else if (outMetric == "in")
            {
                num *= 39.3700787;
            }
            else if (outMetric == "km")
            {
                num *= 0.001;
            }
            else if (outMetric == "ft")
            {
                num *= 3.2808399;
            }
            else if (outMetric == "yd")
            {
                num *= 1.0936133;
            }

            Console.WriteLine("{0} {1}", num, outMetric);

        }
    }
}
