using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor 1: ");
            int t1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o tamanho do vetor 2: ");
            int t2 = int.Parse(Console.ReadLine());

            int menor = 0;

            if (t1 <= t2)
                menor = t1;
            else
                menor = t2;

            int[] v1 = new int[t1];
            int[] v2 = new int[t2];
            int[] v3 = new int[menor];

            Console.WriteLine("\nDigite os elementos do vetor 1: ");
            for (int i = 0; i < v1.Length; i++)
                v1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite os elementos do vetor 2: ");
            for (int i = 0; i < v2.Length; i++)
                v2[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < v1.Length; i++)
                v3[i] = -99999999;

            Interseccao(v1, v2, ref v3);

            Console.WriteLine("\nInterseccao dos dois vetores: ");

            for (int i = 0; i < v3.Length; i++)
                if (v3[i] != -99999999)
                    Console.WriteLine(v3[i]);
        }
        
        static void Interseccao(int[] v1, int[] v2, ref int[] v3)
        {
            int cont = 0;
            int k = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                for (int j = 0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        cont = 0;
                        for (int m = 0; m < v3.Length; m++)
                        {
                            if (v1[i] == v3[m])
                            {
                                cont = cont + 1;
                            }
                        }
                        if (cont == 0)
                        {
                            v3[k] = v1[i];
                            k++;     
                        } 
                    }
                }
            }
        }
    }
}
