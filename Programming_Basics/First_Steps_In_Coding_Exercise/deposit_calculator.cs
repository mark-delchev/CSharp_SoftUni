using System;
namespace Money
{
    class Calculator
    {
        static void Main()
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;
            double final_sum = deposit + months * ((deposit * percentage) / 12);
            Console.WriteLine(final_sum);

        }
    }
}