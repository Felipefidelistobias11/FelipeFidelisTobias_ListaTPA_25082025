using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < 14; i++) 
            {
                b = int.Parse(Console.ReadLine());
                if (c < a)
                {
                    c = a;
                }
                else if (c < b) 
                {
                    c = b;
                }
            }
            Console.WriteLine(c);
        }
    }
}
