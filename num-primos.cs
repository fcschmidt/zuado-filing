using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace maiores_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Console.WriteLine("Digite um número:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    cont = cont + 1;
                }
                if (cont > 2)
                {
                    Console.WriteLine("O " + num + " não é primo!");
                }
                else
                {
                    Console.WriteLine("O " + num + " é primo.");
                }
            }
            Console.ReadLine();
        }
    }
}
