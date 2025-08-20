using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, d, contador1 = 0, contador2 = 0, contador3 = 0, contador4 = 0;
            string j;
            Console.WriteLine("Quantos numeros deseja escrever?");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                d = int.Parse(Console.ReadLine());
                if (d % 2 == 0)
                {
                    contador1++;
                }
                if (d % 2 != 0)
                {
                    contador2++;
                }
                if (d >= 0)
                {
                    contador3++;
                }
                if (d < 0)
                {
                    contador4++;
                }
            }
            Console.WriteLine("Você digitou no total:");
            Console.WriteLine((contador1) + " numeros pares");
            Console.WriteLine((contador2) + " numeros impares");
            Console.WriteLine((contador3) + " numeros positivos");
            Console.WriteLine((contador4) + " numeros negativos\n");

            Console.WriteLine("Deseja encerrar o programa?");
            Console.WriteLine("(S para Sim e N para Não)");
            j = Console.ReadLine();
            while (j == "S")
            {
                return;
            }
            while (j == "N")
            {
                contador1 = 0;
                contador2 = 0;
                contador3 = 0;
                contador4 = 0;
                Console.WriteLine("Quantos numeros deseja escrever?");
                a = int.Parse(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    d = int.Parse(Console.ReadLine());
                    if (d % 2 == 0)
                    {
                        contador1++;
                    }
                    if (d % 2 != 0)
                    {
                        contador2++;
                    }
                    if (d >= 0)
                    {
                        contador3++;
                    }
                    if (d < 0)
                    {
                        contador4++;
                    }
                }
                Console.WriteLine("Você digitou no total:");
                Console.WriteLine((contador1) + " numeros pares");
                Console.WriteLine((contador2) + " numeros impares");
                Console.WriteLine((contador3) + " numeros positivos");
                Console.WriteLine((contador4) + " numeros negativos\n");

                Console.WriteLine("Deseja encerrar o programa?");
                Console.WriteLine("(S para Sim e N para Não)");
                j = Console.ReadLine();
            }
        }
    }
}
