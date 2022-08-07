using System;
namespace Idontundestandwhatnamespacesare
{
    class whatisaclass
    {
        static void Main()
        {
            int pages = int.Parse(Console.ReadLine());
            int page_per_hour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int time_needed = pages / page_per_hour;
            int hours = time_needed / days;
            Console.WriteLine(hours);
        }
    }
}