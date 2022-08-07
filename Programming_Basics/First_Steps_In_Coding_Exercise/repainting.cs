using System;
namespace No
{
    class Yes
    {
        static void Main()
        {
            double nailon = 1.5;
            double paint = 14.5;
            double razreditel = 5.00;
            double nailon_needed = double.Parse(Console.ReadLine()) + 2;
            double paint_needed = double.Parse(Console.ReadLine());
            double paint_needed_finale = paint_needed + paint_needed * 0.10;
            double razreditel_needed = double.Parse(Console.ReadLine());
            double work = double.Parse(Console.ReadLine());
            double materials_price = (nailon * nailon_needed) + (paint * paint_needed_finale) + (razreditel * razreditel_needed) + 0.40;
            double work_price = (materials_price * 0.30) * work;
            double final_price = materials_price + work_price;
            Console.WriteLine(final_price);
        }
    }
}