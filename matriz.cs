using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Digite o tamanho da linha da matriz:");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o tamanho da coluna da matriz:");    
            int colunas = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite " + linhas * colunas + " números.");
            


            int[,] matriz = new int[linhas, colunas];
            for(int i = 0; i < linhas; i ++){
                for (int j = 0; j < colunas; j++){
                    if (i == j)
                        matriz[i, j] = int.Parse(Console.ReadLine());
                        Console.Write(" " + matriz[i, j]);

                }
                Console.Write("\n");
            }
           
        
            Console.ReadLine();

        }
    }
}
