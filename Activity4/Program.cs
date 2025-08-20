using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int u, d;
            Console.WriteLine("Escreva um numero");
            u = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro numero");
            d = int.Parse(Console.ReadLine());
            int i = (d - u);
            if (u % 2 != 0)
            {
                Console.WriteLine((i/2) + 1);
            }
            else
            {
                Console.WriteLine(i / 2);
            }
        }
    }
}
