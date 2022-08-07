using System;

namespace HelloWorldApp
{
    class hello
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int area = a * b;
            Console.WriteLine(area);
        }
    }
}

