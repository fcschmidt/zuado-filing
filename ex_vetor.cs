using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o código: \n(0)Finalizar. \n(1)Odem Direta. \n(2)Ordem Inversa.");
            int codigo = int.Parse(Console.ReadLine());

            double[] vetor = new double[5];
            Console.WriteLine("Digite o valor");
            for (int i = 0; i < 4; i++)
            { 
                vetor[i] = int.Parse(Console.ReadLine());
            }

            if (codigo == 0)
            {
                Console.WriteLine("Finalizar!");
            }
            else if (codigo == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
            else if (codigo == 2)
            {
                for (int i = 4; i < 0; i--)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
            else
                Console.WriteLine("Código inválido!");
            Console.ReadLine();
        }
    }
}
