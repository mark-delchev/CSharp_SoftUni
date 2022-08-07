using System;
namespace kvoeetva
{
    class nerazbiram
    {
        static void Main()
        {
            double pens = 5.8;
            double markers = 7.2;
            double detergent = 1.2;
            int pen_num = int.Parse(Console.ReadLine());
            int marker_num = int.Parse(Console.ReadLine());
            int detergent_liter = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine()) / 100;
            double price = pens * pen_num + markers * marker_num + detergent * detergent_liter;
            double final_price = price - (price * discount);
            Console.WriteLine(final_price);
        }
        

    }
}