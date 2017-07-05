using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace intervalo_par
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programa calcula dois valores e mostra
             * os pares compreendidos entre os dois valores incluindo os valores
             * inicial e final.
             */
            Console.WriteLine("Digite o 1º valor:");//recebe o primeiro valor
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor:");//recebe o segundo valor
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("\n");
            
            if (n1 < n2)//verifica se o primeiro número é menor que o segundo
            {
                Console.WriteLine("Números pares:");
                for (int i = 0; i <= n2; i++)
                {
                    if (i % 2 == 0)
                    {   
                        Console.WriteLine("O número " + i + " é par.");
                    }
                }
            }
            else
                Console.WriteLine("Intevalo incorreto!");

            Console.ReadLine();
        }
    }
}
