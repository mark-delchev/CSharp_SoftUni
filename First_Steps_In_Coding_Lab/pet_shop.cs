using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dog_food = double.Parse(Console.ReadLine());
            double cat_food = double.Parse(Console.ReadLine());
            double dog_price = 2.5;
            double cat_price = 4.0;
            double cat_price_final = cat_price * cat_food;
            double dog_price_final = dog_price * dog_food;
            double final_price = dog_price_final + cat_price_final;
            Console.WriteLine($"{final_price} lv.");
        }
    }
}