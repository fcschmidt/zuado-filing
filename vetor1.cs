using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            Console.WriteLine("Digite o número do vetor:");
            
            int [] vetor = new int[10] ;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; i < vetor.Length - 1; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        valor = vetor[i + 1];
                        vetor[i + 1] = vetor[i];
                        vetor[i] = valor;
                    }
                }
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}" ,vetor[i]);
            }

            Console.ReadLine();
        }
    }
}
