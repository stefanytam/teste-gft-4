using System;

namespace teste_gft_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, div;
            div = 0;
            do
            {
                Console.WriteLine("Digite um valor entre 3 e 999: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 3 || n >= 999);
            for (int i = 3; i < n; i++)
            {
                if (div % i == 0)
                {
                    div++;
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
