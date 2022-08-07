using System;
namespace HEEEEE
{
    class HHHHHHHH
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;
            double liters = ((length * width * height) / 1000) * (1 - percentage);
            Console.WriteLine(liters);
        }
    }
}