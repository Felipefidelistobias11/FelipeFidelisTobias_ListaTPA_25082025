using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Escreva um numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro numero");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i >= b; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            if (b > a)
            {
                int d = b;
                int e = a;
                for (int i = b; i >= a; i--)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
