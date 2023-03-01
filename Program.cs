using System;
using System.Globalization;

namespace N_Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int a = int.Parse(vet[0]);
                int b = int.Parse(vet[1]);

                if (b == 0)
                {
                    Console.WriteLine("Divisão impossível!");
                }
                else
                {
                    double div = (double) a / b;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
