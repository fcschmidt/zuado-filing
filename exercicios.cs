using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace execicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();

            // Força o aplicativo a parar
            Console.ReadLine();
        }

        static void Exercicio1()
        {
            //linhas e colunas, preenche a matriz com aleatórios, converte para binários e imprime ambas.
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("Exercicio 1: Matriz decimal para binário");
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
            Console.WriteLine("Matriz binária");
            ImprimirMatriz(matrizBinaria);
        }

        static void Exercicio2()
        {
            //tamanhos dos dois vetores, popula com aleat?rios, imprime ambos, retorna a intersec??o e imprim
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("Exercício 2: Intersecção entre vetores");
            Console.WriteLine("============================================");

            Console.Write("Tamanho vetor1 (> 0): ");
            int tamanho1 = int.Parse(Console.ReadLine());
            Console.Write("Tamanho vetor2 (> 0): ");
            int tamanho2 = int.Parse(Console.ReadLine());

            int[] vetor1 = new int[tamanho1];
            int[] vetor2 = new int[tamanho2];

            PopularVetorComAleatorios(ref vetor1);
            PopularVetorComAleatorios(ref vetor2);

            Console.WriteLine("Vetor 1");
            ImprimirVetor(vetor1);
            Console.WriteLine("\nVetor 2");
            ImprimirVetor(vetor2);

            int[] interseccao = Interseccao(vetor1, vetor2);
            Console.WriteLine("\nIntersecção");
            ImprimirVetor(interseccao);
        }

        static void Exercicio3()
        {
            //tamanhos dos três vetores, popula com aleatórios, imprime, retorna a união sem duplicatas e imprime
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("Exercício 3: União sem duplicatas");
            Console.WriteLine("============================================");

            Console.Write("Tamanho vetor1 (> 0): ");
            int tamanho1 = int.Parse(Console.ReadLine());
            Console.Write("Tamanho vetor2 (> 0): ");
            int tamanho2 = int.Parse(Console.ReadLine());
            Console.Write("Tamanho vetor3 (> 0): ");
            int tamanho3 = int.Parse(Console.ReadLine());

            int[] vetor1 = new int[tamanho1];
            int[] vetor2 = new int[tamanho2];
            int[] vetor3 = new int[tamanho3];

            PopularVetorComAleatorios(ref vetor1);
            PopularVetorComAleatorios(ref vetor2);
            PopularVetorComAleatorios(ref vetor3);

            Console.WriteLine("Vetor 1");
            ImprimirVetor(vetor1);
            Console.WriteLine("\nVetor 2");
            ImprimirVetor(vetor2);
            Console.WriteLine("\nVetor 3");
            ImprimirVetor(vetor3);

            int[] uniao = UniaoSemDuplicatas(vetor1, vetor2, vetor3);
            Console.WriteLine("\nUnião");
            ImprimirVetor(uniao);
        }

        static void Exercicio4()
        {
            //linhas e colunas, preenche a matriz com aleatórios, ordena suas linhas, imprime os dados.
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("Exercício 4: Ordenar linhas da matriz.");
            Console.WriteLine("============================================");

            Console.Write("Número de linhas (> 0): ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Número de colunas (> 0): ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];
            PopularMatrizComAleatorios(ref matriz);

            Console.WriteLine("Matriz:");
            ImprimirMatriz(matriz);

            OrdenarLinhasDaMatriz(ref matriz);
            Console.WriteLine("\nMatriz com linhas ordenadas:");
            ImprimirMatriz(matriz);
        }

        static void Exercicio5()
        {
            //linhas e colunas, preenche a matriz com aleatórios, busca o maior elemento e sua posição, imprime os dados.
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("Exercício 5: Maior elemento de uma matriz e sua posição.");
            Console.WriteLine("============================================");

            Console.Write("Número de linhas (> 0): ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Número de colunas (> 0): ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];
            PopularMatrizComAleatorios(ref matriz);

            Console.WriteLine("Matriz:");
            ImprimirMatriz(matriz);

            int maior = 0; // guarda o maior elemento da matriz
            int x = 0, y = 0; // posição do elemento
            MaiorElementoDaMatriz(matriz, ref maior, ref x, ref y);
            Console.WriteLine("Maior elemento: " + maior);
            Console.WriteLine("Posi??o do maior elemento: [" + x + ", " + y + "]");
        }


        /*
         * Recebe um vetor por referência e
         * popula todas as suas posiçôes com valores aleatórios.
         */
        static void PopularVetorComAleatorios(ref int[] vetor)
        {
            // Não se preocupem - se para gerar aleatórios realmente diferentes
            Thread.Sleep(20);

            // Cria o gerador de números aleatórios
            Random rnd = new Random();
            // Percorre todas as posições do vetor
            for (int i = 0; i < vetor.Length; i++)
                // Seta cada posição com um aleatório menor igual a 15
                vetor[i] = rnd.Next(15);
        }

        /*
         * Recebe uma matriz por referência e 
         * popula todas as suas posições com valores aleatórios de 0 a 15.
         */
        static void PopularMatrizComAleatorios(ref int[,] matriz)
        {
            // Não se preocupem - se para gerar aleatórios realmente diferentes
            Thread.Sleep(20);

            // Cria o gerador de números aleatórios
            Random rnd = new Random();
            // Percorre todas as posições da matriz
            for (int i = 0; i < matriz.GetLongLength(0); i++)
                for (int j = 0; j < matriz.GetLongLength(1); j++)
                    // Para cada posição, seta um número aleatório de máximo 15
                    matriz[i, j] = rnd.Next(15);
        }

        /*
         * Faz a impressão de uma matriz, passada como parametro.
         */
        static void ImprimirMatriz(int[,] matriz)
        {
            // Faz dois for para percorrer todas as posições da matriz
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
         * Imprime todos os elementos de um vetor, separados por virgula
         */
        static void ImprimirVetor(int[] vetor)
        {
            // Percorre todas as posições do vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                // Imprime cada posição
                Console.Write(vetor[i]);
                // Se não for a última posição, imprime a vírgula para separar
                if (i != vetor.Length - 1)
                    Console.Write(", ");
            }
        }

        /*
         * Converte um número inteiro de decimal para binário.
         * Recebe como parâmetro uma variável inteira, que será convertida,
         * e retorna um inteiro com o número binário.
         * 
         * Exemplo: 10 -> 1010
         * 10 / 2
         *  0   5 / 2
         *      1   2 / 2
         *          0   1 (começa aqui)
         *         
         */
        static int DecimalParaBinario(int a)
        {
            // Armazena os resultados das contas de divisão, ao contrário.
            String valor = "";
            // Dividendo - usado em cada iteração para geração dos mods.
            int dividendo = a; // inicia com o próprio número passado

            // se o número menor que 2, ele seu próprio binário
            if (dividendo < 2)
                return dividendo;
            else
            {
                // continua a conta até que o dividendo seja 0
                while (dividendo > 0)
                {
                    // guarda no valor o dividendo mod 2
                    valor += Convert.ToString(dividendo % 2);
                    // atualiza o dividendo, que agora ? div/2
                    dividendo = dividendo / 2;
                }
                // A variável valor guarda a string com o binário ao contrário.
                // Deve ser invertida para retornar o resultado correto (função InverterString)
                // Como a função retorna um int, deve converter o valor (string) para int.
                return int.Parse(InverterString(valor));
            }
        }


        /*
         * Recebe uma matriz e retorna sua representação em binário
         */
        static int[,] MatrizInteiroParaBinario(int[,] matriz)
        {
            // número de linhas da matriz
            int linhas = matriz.GetLength(0);
            // número de colunas da matriz
            int colunas = matriz.GetLength(1);
            // cria a matriz que vai guardar os binários
            int[,] matrizBinaria = new int[linhas, colunas];
            // percorre todas as posições da matriz
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    // seta na matriz binária a conversão de decimal para binário
                    // de cada posição da matriz original
                    matrizBinaria[i, j] = DecimalParaBinario(matriz[i, j]);

            // retorna a matriz binária
            return matrizBinaria;
        }


        /*
         * Retorna uma string invertida, recebida por parâmetro.
         * Para isso, quebra a string invertida em um vetor de char, 
         * cria um vetor de char com a string invertida e preenche a invertida com a string ao contrário
         */
        public static String InverterString(String str)
        {
            // Quebra a string recebida em um vetor de char
            char[] frase = str.ToCharArray();
            // Pega o tamanho da string, para percorrer no for
            int tamanho = frase.Length;
            // Cria a variável que vai guardar a string invertida
            char[] invertida = new char[frase.Length];

            // Percorre todas as posiçôes da frase
            for (int i = 0; i < tamanho; i++)
                // Para toda posiçõo da frase, preenche a invertida ao contrário
                invertida[i] = frase[tamanho - 1 - i];

            // Retorna a invertida como string (era um vetor de char)
            return new string(invertida);
        }


        /*
         * Retorna a intersecção entre dois vetores, passados por parâmetro.
         * 
         * Para isso, armazena em uma string os elementos em comum.
         * Depois quebra a string em um vetor de string.
         */
        public static int[] Interseccao(int[] v1, int[] v2)
        {
            // começa removendo duplicatas dos dois vetores
            EliminarDuplicatas(ref v1);
            EliminarDuplicatas(ref v2);

            // string que guarda os elementos que pertencem intersecção v1-v2
            String interseccao = "";
            // Percorre os elementos do vetor 1
            for (int i = 0; i < v1.Length; i++)
                // Se o elemento estão no vetor1 e no vetor2
                if (IncluidoNoVetor(v1[i], v2))
                {
                    if (interseccao != "")
                        // Concatena na string de intersecção
                        interseccao += ';';
                    interseccao += v1[i];
                }

            // Quebra a string intersecção em um vetor de string
            String[] interseccaoArr = interseccao.Split(';');
            // Converte o vetor de string para int
            int[] interseccaoInt = ConverterVetorStringParaInt(interseccaoArr);
            return interseccaoInt;

        }

        /*
         * Retorna a união entre três vetores sem duplicatas.
         */
        static int[] UniaoSemDuplicatas(int[] vetor1, int[] vetor2, int[] vetor3)
        {
            // cria um vetor cujo tamanho a soma dos três
            int[] uniao = new int[vetor1.Length + vetor2.Length + vetor3.Length];

            // inclui os elementos do vetor1
            for (int i = 0; i < vetor1.Length; i++)
                uniao[i] = vetor1[i];

            // inclui os elementos do vetor2
            // a partir da posição que parou depois do vetor1
            for (int i = 0; i < vetor2.Length; i++)
                uniao[vetor1.Length + i] = vetor2[i];

            // inclui os elementos do vetor3
            // a partir da posição que parou depois do vetor2
            for (int i = 0; i < vetor3.Length; i++)
                uniao[vetor1.Length + vetor2.Length + i] = vetor3[i];

            // elimina duplicatas e retorna
            EliminarDuplicatas(ref uniao);
            return uniao;
        }

        /*
         * Converte um vetor de string para inteiro.
         */
        public static int[] ConverterVetorStringParaInt(string[] vetor)
        {
            // Guarda o vetor de inteiros que será preenchido
            int[] vetorInt = new int[vetor.Length];
            // Percorre todas as posições do vetor
            for (int i = 0; i < vetor.Length; i++)
                // Para cada posição do vetor (string), seta seu valor no vetor de int
                vetorInt[i] = int.Parse(vetor[i]);
            // retorna o vetor de int
            return vetorInt;
        }

        /*
         * Elimina as duplicatas de um vetor, passado por referência.
         * Para isso, usa um vetor auxiliar, que preenchido com os elementos sem duplicatas.
         */
        public static void EliminarDuplicatas(ref int[] vetor)
        {
            // vetor auxiliar de mesmo tamanho do original
            int[] auxiliar = new int[vetor.Length];
            // indice - posição máxima da preenchimento do vetor auxiliar
            int indice = -1;
            // Percorre as posições do vetor original
            for (int i = 0; i < vetor.Length; i++)
                // se n?o está incluído no vetor auxiliar, então não duplicado
                // se não duplicado, aumenta o indice e inclui no vetor auxiliar
                if (!IncluidoNoVetor(vetor[i], auxiliar))
                {
                    indice++;
                    auxiliar[indice] = vetor[i];
                }
            // Retorna o auxiliar até o indice, posição máxima onde ele preenchido.
            vetor = VetorAteIndice(auxiliar, indice);
        }

        /*
         * Retorna se um vetor está incluído em um vetor.
         */
        public static Boolean IncluidoNoVetor(int valor, int[] vetor)
        {
            // Percorre o vetor
            for (int i = 0; i < vetor.Length; i++)
                // se o valor igual o da posição corrente, então está incluído no vetor e retorna
                if (valor == vetor[i])
                    return true;
            // não está incluído, retorna false
            return false;
        }


        /*
         * Retorna um vetor até determinado indice.
         * Por exemplo: vetor = {1, 2, 3, 5, 8, 10} e indice = 3 retorna até a posição 3: {1, 2, 3, 5}
         */
        public static int[] VetorAteIndice(int[] vetor, int indice)
        {
            // Cria um vetor auxiliar cujo tamanho o ind?ce + 1
            int[] auxiliar = new int[indice + 1];
            // Percorre as posições do vetor até a final (indice)
            for (int i = 0; i <= indice; i++)
                // Para cada posição, seta o vetor auxiliar
                auxiliar[i] = vetor[i];
            // Retorna o auxiliar
            return auxiliar;
        }

        /*
         * Percorre uma matriz em busca de seu maior elemento.
         * Retorna por referência o maior elemento e sua posição.
         */
        public static void MaiorElementoDaMatriz(int[,] matriz, ref int maior, ref int x, ref int y)
        {
            // Indica que o maior o primeiro elemento
            maior = matriz[0, 0];
            x = 0;
            y = 0;

            // Percorre todos os elementos da matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    // se este elemento o novo maior
                    if (matriz[i, j] > maior)
                    {
                        // seta a variavel que guarda o maior e sua posição
                        maior = matriz[i, j];
                        x = i;
                        y = j;
                    }

        }

        /*
         * Ordena as linhas de uma matriz passada por referência.
         */
        static void OrdenarLinhasDaMatriz(ref int[,] matriz)
        {
            // estabelece uma variável auxiliar que será usada para troca das posições
            int auxiliar;
            // percorre a matriz com for(i) e for(j)
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    // Percorre os elementos de cada linha da matriz
                    // Inicia no segundo elemento, pois ele será comparado com o primeiro
                    for (int k = (j + 1); k < matriz.GetLength(1); k++)
                        // Se o elemento seguinte menor que o anterior
                        // Troca sua posição com o anterior
                        if (matriz[i, j] > matriz[i, k])
                        {
                            // Troca os elementos de posição
                            auxiliar = matriz[i, k];
                            matriz[i, k] = matriz[i, j];
                            matriz[i, j] = auxiliar;
                        }
        }

    }
}
