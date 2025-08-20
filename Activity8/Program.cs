using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, fato = 1;
            Console.WriteLine("Informe um numero");
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++) 
            {
                fato *= i;
                Console.WriteLine(i + "!=" + fato);
            }
        }
    }
}
