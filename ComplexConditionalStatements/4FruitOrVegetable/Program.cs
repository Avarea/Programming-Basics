using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Плодовете "fruit" са banana, apple, kiwi, cherry, lemon и grapes
//Зеленчуците "vegetable" са tomato, cucumber, pepper и carrot
//Всички останали са "unknown"

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" || input == "lemon" || input == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (input == "tomato" || input == "cucumber" || input == "pepper" || input == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}

