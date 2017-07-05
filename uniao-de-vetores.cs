using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace união_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor 1:");
            int t1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o tamanho do vetor 2:");
            int t2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o tamanho do vetor 3:");
            int t3 = int.Parse(Console.ReadLine());
            

            int[] vet1 = new int[t1];
            int[] vet2 = new int[t2];
            int[] vet3 = new int[t3];
            int[] uniao = new int[vet1.Length+vet2.Length+vet3.Length];
           
            Console.WriteLine("\nDigite os valores do vetor 1:");
            for (int i = 0; i < vet1.Length; i++)
                 vet1[i] = int.Parse(Console.ReadLine());
       
            Console.WriteLine("\nDigite os valores do vetor 2:");  
            for (int j = 0; j < vet2.Length; j++)        
                 vet2[j] = int.Parse(Console.ReadLine());           
                
            Console.WriteLine("\nDigite os valores do vetor 3:");
            for (int k = 0; k < vet3.Length; k++)
                   vet3[k] = int.Parse(Console.ReadLine());

            Uniao(vet1, vet2, vet3, ref uniao);

            Console.WriteLine("\nA união dos três vetores é:");

                  Console.ReadKey();
        }

        static void Uniao(int [] vet1, int[] vet2, int[] vet3, ref int[] uniao)
        {
            for (int i = 0; i < vet1.Length; i++)
            {
                for (int j = 0; j < vet2.Length; j++)
                {
                    for (int k = 0; k < vet3.Length; k++)
                    {
                       


                         
                }
            }
        }           
    }
}

        
