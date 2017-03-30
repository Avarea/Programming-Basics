using System;
namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long countPictures = long.Parse(Console.ReadLine());
            long filterTimeForOnePicture = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());
            double filterPicture = Math.Ceiling(countPictures * (filterFactor / 100.0));
            double firstAnswer = countPictures * filterTimeForOnePicture;
            double secondAnswer = filterPicture * uploadTime;
            double answer = firstAnswer + secondAnswer;
            TimeSpan time = TimeSpan.FromSeconds(answer);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
        }
    }
}
