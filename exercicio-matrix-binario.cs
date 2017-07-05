using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exerciciosmatrizbinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o numero de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] m = new int[linhas,colunas];

            Console.Write("\n");
            for (int i = 0; i < m.GetLongLength(0); i++)
            {
                for (int j = 0; j < m.GetLongLength(1); j++)
                {
                    Console.Write("Digite o elemento [{0},{1}]: " , i+1, j+1);
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < m.GetLongLength(0); i++)
            {
                for (int j = 0; j < m.GetLongLength(1); j++)
                {
                    Console.Write("  " + m[i, j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine("\nMatriz em binario:");

            for (int i = 0; i < m.GetLongLength(0); i++)
            {
                for (int j = 0; j < m.GetLongLength(1); j++)
                {
                    if (m[i, j] == 0)
                        Console.Write("   " + m[i, j]);
                    else
                        ConverteParaBinario(m, i, j);
                }
                Console.Write("\n");
            }
        }

        static void ConverteParaBinario(int[,] m, int i, int j)
        {
            int[] vBin = new int[50];
            int pos = 0;
            int resultado = m[i,j];

            while (resultado >= 1)
            {
                 vBin[pos] = resultado % 2;
                 resultado = resultado / 2;
                 pos++;
            }
            
            pos--;

            while (pos >= 0)
            {
                Console.Write(vBin[pos]);
                pos--;
            }
            Console.Write("   ");

            Console.ReadLine();
        }
    }
}
