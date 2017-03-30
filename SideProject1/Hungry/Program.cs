using System;



class Program
{
    static void Main()
    {

        Console.WriteLine("Гладни ли сме днес?");
        Console.Write("Моля отговори с ДА/НЕ:  ");
        string hungry = Console.ReadLine().ToLower();
        if (hungry == "да")
        {
            Console.WriteLine("Кои от следните продукти не ядете?");
            Console.WriteLine("чесън");
            string chesyn = Console.ReadLine();
            Console.WriteLine("риба");
            string riba = Console.ReadLine();
            Console.WriteLine("месо");
            string meso = Console.ReadLine();
            Console.WriteLine("чушки");
            string chushki = Console.ReadLine();
            Console.WriteLine("лук");
            string luk = Console.ReadLine();
            Console.WriteLine("тестени изделия");
            string testp = Console.ReadLine();
            Console.WriteLine("арпаджик");
            string arpadjik = Console.ReadLine();
        }
        else if (hungry == "не")
        {
            Console.WriteLine("Жалко, върни се пак, когато си гладен :)");
            return;
        }
        else 
        {
            Console.WriteLine("Моля отговорете с ДА или НЕ");
            hungry = Console.ReadLine().ToLower();
        }
        Console.Clear();
        Console.WriteLine("Днес ще си сготвиш Билково Филе:");
        Console.WriteLine("Необгодими продукти:");
        Console.WriteLine("600 г телешко или говеждо филе - цяло парче");
        Console.WriteLine("2 стръка мащерка");
        Console.WriteLine("2 стръка градински чай");
        Console.WriteLine("2 стръка розмарин");
        Console.WriteLine("2 бр.дафинов лист");
        Console.WriteLine("2 скилидки чесън");
        Console.WriteLine("2 с.л.олио");
        Console.WriteLine("сол, черен пипер");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Начин на приготвяне");
        Console.WriteLine("Листата на градинския чай, мащерката и розмарина се нарязват на много ситно или се смилат. Поръсват се със сол и пипер. Филето се овалва добре в билките. В тиган се загрява олиото и филето се запържва от всички страни. Филето се поставя в съд за печене и около него се поставят стеблата на билките, дафиновия лист и смачкания необелен чесън. Покрива се с фолио и се запича в предварително загрята, умерена фурна до готовност.");

        Console.WriteLine();
        Console.WriteLine("Желаеш ли друга рецепта?");
        string another = Console.ReadLine().ToLower();
        if (another == "не")
        {
            Console.WriteLine("Бон Апети :)");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Днес ще си сготвиш Супа от коприва или спанак:");
            Console.WriteLine("Необгодими продукти:");
            Console.WriteLine("500 г коприва или спанак");
            Console.WriteLine("1 - 2 бр.моркови");
            Console.WriteLine("1 глава лук");
            Console.WriteLine("1 бр. жълтък");
            Console.WriteLine("200 г кисело мляко");
            Console.WriteLine("фиде");
            Console.WriteLine("2 с.л.ориз");
            Console.WriteLine("джоджен");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Начин на приготвяне");
            Console.WriteLine("В малко мазнина се задушават лука и моркова. Добавя се измитата коприва (измития и нарязан спанак) и се обърква хубаво с моркова и лука. След това се налива топла вода, като количеството зависи от желаната гъстота на супата. След като копривата поври 15-20 минути се добавя ориза и малко преди да е готов се добавя фидето. Супата се овкусява със сол и се добавя джоджен на вкус. След като е готово и фидето супата се застройва със застройка, приготвена от жълтъка, разбит с киселото мляко.");
            Console.WriteLine();
            Console.WriteLine("Толкоз...да си ял...смотаняк");
        }

    }

}

