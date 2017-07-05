using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrizparabinario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
       
            //linhas e colunas, preenche a matriz com aleatórios, converte para binários e imprime ambas.
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("Exercício 1: Matriz decimal para binário");
            Console.WriteLine("============================================");

            Console.Write("Número de linhas (> 0): ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Número de colunas (> 0): ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];
            PopularMatrizComAleatorios(ref matriz);

            Console.WriteLine("Matriz decimal");
            ImprimirMatriz(matriz);

            int[,] matrizBinaria = MatrizInteiroParaBinario(matriz);
            Console.WriteLine("Matriz bin?ria");
            ImprimirMatriz(matrizBinaria);
        }

          /*
         * Recebe uma matriz por referência e 
         * popula todas as suas posições com valores aleat?rios de 0 a 15.
         */
        static void PopularMatrizComAleatorios(ref int[,] matriz)
        {
            // Não se preocupem - ? s? para gerar aleat?rios realmente diferentes
            Thread.Sleep(20);

            // Cria o gerador de n?meros aleat?rios
            Random rnd = new Random();
            // Percorre todas as posi??es da matriz
            for (int i = 0; i < matriz.GetLongLength(0); i++)
                for (int j = 0; j < matriz.GetLongLength(1); j++)
                    // Para cada posi??o, seta um n?mero aleat?rio de m?ximo 15
                    matriz[i, j] = rnd.Next(15);
        }

        /*
         * Faz a impress?o de uma matriz, passada como par?metro.
         */
        static void ImprimirMatriz(int[,] matriz)
        {
            // Faz dois for para percorrer todas as posi??es da matriz
            for (int i = 0; i < matriz.GetLongLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(1); j++)
                    // Imprime as colunas
                    Console.Write(matriz[i, j] + " ");
                // Ao terminar a linha, imprime uma quebra de linha
                Console.WriteLine();
            }
        }

        /*
         * Converte um n?mero inteiro de decimal para bin?rio.
         * Recebe como par?metro uma vari?vel inteira, que ser? convertida,
         * e retorna um inteiro com o n?mero bin?rio.
         * 
         * Exemplo: 10 -> 1010
         * 10 / 2
         *  0   5 / 2
         *      1   2 / 2
         *          0   1 (come?a aqui)
         *         
         */
        static int DecimalParaBinario(int a)
        {
            // Armazena os resultados das contas de divis?o, ao contr?rio.
            String valor = "";
            // Dividendo - usado em cada itera??o para gera??o dos mods.
            int dividendo = a; // inicia com o pr?prio n?mero passado

            // se o n?mero ? menor que 2, ele ? seu pr?prio bin?rio
            if (dividendo < 2)
                return dividendo;
            else
            {
                // continua a conta at? que o dividendo seja 0
                while (dividendo > 0)
                {
                    // guarda no valor o dividendo mod 2
                    valor += Convert.ToString(dividendo % 2);
                    // atualiza o dividendo, que agora ? div/2
                    dividendo = dividendo / 2;
                }
                // A vari?vel valor guarda a string com o bin?rio ao contr?rio.
                // Deve ser invertida para retornar o resultado correto (fun??o InverterString)
                // Como a fun??o retorna um int, deve converter o valor (string) para int.
                return int.Parse(InverterString(valor));
            }
        }


        /*
         * Recebe uma matriz e retorna sua representa??o em bin?rio
         */
        static int[,] MatrizInteiroParaBinario(int[,] matriz)
        {
            // n?mero de linhas da matriz
            int linhas = matriz.GetLength(0);
            // n?mero de colunas da matriz
            int colunas = matriz.GetLength(1);
            // cria a matriz que vai guardar os bin?rios
            int[,] matrizBinaria = new int[linhas, colunas];
            // percorre todas as posi??es da matriz
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    // seta na matriz bin?ria a convers?o de decimal para bin?rio
                    // de cada posi??o da matriz original
                    matrizBinaria[i, j] = DecimalParaBinario(matriz[i, j]);

            // retorna a matriz bin?ria
            return matrizBinaria;
        }
        }
    }
}
