using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mostrar_divisores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int divisão = 0;

            while (num != 0)
            {
                Console.WriteLine("Digite um número.");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------");

                Console.WriteLine("Divisores de " + num);
                Console.WriteLine();

                if (num != 0)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            divisão = num / i;
                            Console.WriteLine(divisão);
                        }
                    }
                }
                if (num < 0)
                {
                    Console.WriteLine("Este programa não faz divisão de números negativos.");
                }
                else if (num == 0)
                {
                    Console.WriteLine("Zero não pode ser dividido.");
                }
            }
            Console.ReadKey();
        }
    }
}
