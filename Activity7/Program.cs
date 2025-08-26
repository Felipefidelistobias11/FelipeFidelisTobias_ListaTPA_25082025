using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 10;
            for (int i = 0; i <= 100; i++) 
            {
                Console.WriteLine(i);
                if (i % 10 == 0) 
                {
                    Console.WriteLine("Mutiplo de 10");  
                }
            }
        }
    }
}