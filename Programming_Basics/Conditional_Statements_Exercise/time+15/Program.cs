using System;
namespace Programs
{
    class Hello
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int time = hours * 60 + minutes;
            int time_15 = time + 15;
            int hour_15 = time_15 / 60;
            int minutes_15 = time_15 % 60;
            if (hour_15 > 23)
            {
                hour_15 = 0;
            }
            if (minutes_15 < 10)
            {
                Console.WriteLine($"{hour_15}:0{minutes_15}");
            }
            else
            {
                Console.WriteLine($"{hour_15}:{minutes_15}");
            }
        }
    }
}
