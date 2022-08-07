using System;
namespace What
{
    class No
    {
        static void Main()
        {
            int year_price = int.Parse(Console.ReadLine());
            double shoes = year_price * 0.6;
            double jersey = shoes * 0.8;
            double ball = jersey * 0.25;
            double accsesories = ball * 0.2;
            double total_price = year_price + shoes + jersey + ball + accsesories;
            Console.WriteLine(total_price);
        }
    }
}