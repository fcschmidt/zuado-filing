using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercicio 1: CALCULO DO AUMENTO DE CADA FUNCIONÁRIO
            
            //lendo as informações do teclado
            Console.WriteLine("Digite o Sálario de João");
            double sJoao = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Sálario de Carlos");
            double sCarlos = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Sálario de Gustavo");
            double sGustavo = double.Parse(Console.ReadLine());


            // atribuindo o percentual de aumento para cada funcionário 
            sJoao = sJoao * 1.1;
            sCarlos = sCarlos * 1.32;
            sGustavo = sGustavo * 1.187;

            //exibição dos resultados
            Console.WriteLine("\nNovo Sálario de João : R$ " + sJoao);
            Console.WriteLine("Novo Sálario de Carlos : R$ " + sCarlos);
            Console.WriteLine("Novo Sálario de Gustavo : R$ " + sGustavo);



            //Exercicios 2: FGTS DOS FUNCIONÁRIOS

            // variaveis que calcula o fgts de cada funcionário 
            double fgtsJoao;
            fgtsJoao = sJoao * 0.08;
            double fgtsCarlos;
            fgtsCarlos = sCarlos * 0.08;
            double fgtsGustavo;
            fgtsGustavo = sGustavo * 0.08;

            // variaveis que calcula o sálario dos funcionários com fgts descontado
            double nJoao;
            nJoao = sJoao - fgtsJoao;
            double nCarlos;
            nCarlos = sCarlos - fgtsCarlos;
            double nGustavo;
            nGustavo = sGustavo - fgtsGustavo;
            nJoao = Math.Round(nJoao, 2);
            nCarlos = Math.Round(nCarlos, 2);
            nGustavo = Math.Round(nGustavo, 2);

            //exibição dos resultados
            Console.WriteLine("\nSálario de João descontado FGTS : R$ " + nJoao);
            Console.WriteLine("Sálario de Carlos descontado o FGTS : R$ " + nCarlos);
            Console.WriteLine("Sálario de Gustavo descontado o FGTS : R$ " + nGustavo);
            Console.WriteLine("--------------------------------------------------------------------------------");


            //Exercicio 3: DÉCIMO TERCEIRO SÁLARIO
            /*Anotações: Calculo do décimo terceiro sálario.
             * João trabalhou desde de Março.
             * Carlos trabalhou desde de Janeiro.
             * Gustavo trabalhou desde de Setembro
              */

            // lê as informações do teclado
            Console.WriteLine("\nDigite quantos meses João Trabalhou");
            double dstJoao = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite quantos meses Carlos Trabalhou");
            double dstCarlos = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite quantos meses Gustavo Trabalhou");
            double dstGustavo = double.Parse(Console.ReadLine());

            dstJoao = dstJoao * (sJoao/12);
            dstCarlos = dstCarlos * (sCarlos / 12);
            dstGustavo = dstGustavo * (sGustavo / 12);
            dstJoao = Math.Round(dstJoao, 2);
            dstCarlos = Math.Round(dstCarlos, 2);
            dstGustavo = Math.Round(dstGustavo, 2);

            //Calculo do FGTS 13º Sálario
            double fdstJoao;
            fdstJoao = dstJoao * 0.08;
            double fdstCarlos;
            fdstCarlos = dstCarlos * 0.08;
            double fdstGustavo;
            fdstGustavo = dstGustavo * 0.08;
            fdstJoao = Math.Round(fdstJoao, 2);
            fdstCarlos = Math.Round(fdstCarlos, 2);
            fdstGustavo = Math.Round(fdstGustavo, 2);

            //exibição dos resultados
            Console.WriteLine("\n13º Sálario de João é: R$ " + (dstJoao-fdstJoao));
            Console.WriteLine("13º Sálario de Carlos é: R$ " + (dstCarlos-fdstCarlos));
            Console.WriteLine("13º Sálario de Gustavo é: R$ " + (dstGustavo-fdstGustavo));
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Exercicio 4: DÉCIMO TERCEIRO TOTAL PAGO 

            // variaveis que calcula o total de 13º pago pela empresa em novembro e dezembro
            double totalnovembro;
            totalnovembro = dstJoao + dstCarlos + dstGustavo / 2;
            double totaldezembro;
            totaldezembro = totalnovembro;
            totalnovembro = Math.Round(totalnovembro, 2);
            totaldezembro = Math.Round(totaldezembro, 2);
            //mostra na tela o calculo
            Console.WriteLine("\nTotal de 13º pago em Novembro : R$ " + totalnovembro);
            Console.WriteLine("Total de 13º pago em Dezembro : R$ " + totaldezembro);
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Exercicio 5:
            
            //calcula o total de FGTS
            double totalfgtsJoao;
            totalfgtsJoao = (10 * fgtsJoao) + fdstJoao;
            double totalfgtsCarlos;
            totalfgtsCarlos = (12 * fgtsCarlos) + fdstCarlos;
            double totalfgtsGustavo;
            totalfgtsGustavo = (4 * fgtsGustavo) + fdstGustavo;
            totalfgtsJoao = Math.Round(totalfgtsJoao, 2);
            totalfgtsCarlos = Math.Round(totalfgtsCarlos, 2);
            totalfgtsGustavo = Math.Round(totalfgtsGustavo, 2);
            
            //exibição dos resultados 
            Console.WriteLine("\nTotal de FGTS recolhido por João : R$ " + totalfgtsJoao);
            Console.WriteLine("Total de FGTS recolhido por Carlos : R$ " + totalfgtsCarlos);
            Console.WriteLine("Total de FGTS recolhido por Gustavo : R$ " + totalfgtsGustavo);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}