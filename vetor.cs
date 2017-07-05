using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vetor.Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor:");
            int t1 = int.Parse(Console.ReadLine());



            int[] vetor = new int[t1];

            Console.WriteLine("Digite os números do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            
            for (int  i = 0; i < vetor.GetLongLength(0); i++)
                for(int j = 0; j < vetor.GetLongLength(1); j++)
                    
                







                    Console.ReadLine();

        }
    }
}
