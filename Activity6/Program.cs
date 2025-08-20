using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int u, t=0;
            int d = 0;
            Console.WriteLine("Escreva as usas notas");
            for (int i = 0; i < 10; i++)
            {
                d = int.Parse(Console.ReadLine());
                if (d <= 0)
                {
                    Console.WriteLine("Não aceitamos valores iguais ou menores que zero");
                    return;
                }
                if (d >= 11)
                {
                    Console.WriteLine("Não aceitamos valores maiores que dez");
                    return;
                }
                t = d+t;
            }
            Console.WriteLine(t / 10);
        }
    }
}
