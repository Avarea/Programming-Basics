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
        var specialNumbers = new StringBuilder();

        for (int i = 1111; i <= 9999; i++)
        {
            bool isSpecialNumber = true;
            string iToString = i.ToString();

            for (int o = 0; o < 4; o++)
            {
                int currentINumber = int.Parse(iToString[o].ToString());

                if (currentINumber == 0 || n % currentINumber != 0)
                {
                    isSpecialNumber = false;
                    break;
                }
            }

            if (isSpecialNumber)
            {
                specialNumbers.Append(i + " ");
            }
        }

        string result = specialNumbers.ToString().Trim();

        Console.WriteLine(specialNumbers);
    }
}

