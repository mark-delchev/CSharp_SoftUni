using System;
namespace Hi
{
    class Hello
    {
        static void Main()
        {
            double chicken_menu = 10.35;
            double fish_menu = 12.40;
            double vegetarian_menu = 8.15;
            int c_menu_num = int.Parse(Console.ReadLine());
            int f_menu_num = int.Parse(Console.ReadLine());
            int v_menu_num = int.Parse(Console.ReadLine());
            double menu_price = (chicken_menu * c_menu_num) + (fish_menu * f_menu_num) + (vegetarian_menu * v_menu_num);
            double dessert = menu_price * 0.20;
            double final_price = menu_price + dessert + 2.50;
            Console.WriteLine(final_price);
        }
    }
}