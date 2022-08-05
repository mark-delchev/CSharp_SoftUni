using System;
namespace Yard
{
    class Progeam
    {
        static void Main(string[] args)
        {
            double square_meters = double.Parse(Console.ReadLine());
            double price = square_meters * 7.61;
            double discount = price * 0.18;
            double final_price = price - discount;
            Console.WriteLine($"The final price is: {final_price} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}