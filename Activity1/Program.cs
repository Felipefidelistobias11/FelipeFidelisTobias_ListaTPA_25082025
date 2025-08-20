using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=11;i<=250;i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
