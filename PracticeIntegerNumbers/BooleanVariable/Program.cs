﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var boolean = Convert.ToBoolean(input);
            if (boolean == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");    
            }
        }
    }
}
