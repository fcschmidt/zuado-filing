using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Programa Conversor de Fontes
*  Author: Fábio Schmidt
*  Ano: 2013
*/

namespace converterpixel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Consersor de Pixel, EM e %.
             * Converte Pixel em EM, Pixel em % e Pixel em Points(PT)
             * Converte EM em Pixel, EM em %.
             */

            double num = 16;//valor padrão do pixel para calculo
            Console.WriteLine("O valor padrão para calcular é de 16px");
            for (int i = -1; i <= 6; i++)
            {

                Console.WriteLine("Escolha a Opção que deseja executar e pressione ENTER:");
                Console.WriteLine("Opções:");
                Console.WriteLine("0 - para Converter Pixel em EMs.");
                Console.WriteLine("1 - para Convert Pixel em %.");
                Console.WriteLine("2 - para Converter Pixel em Points.");
                Console.WriteLine("3 - para Converter EM em Pixel.");
                Console.WriteLine("4 - para Converter EM em %.");
                Console.WriteLine("5 - para Sair");


                if(num > 6 || num < 0){
                    Console.WriteLine("Digite uma das opções validas!");
                }

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0://Converte Pixel em EMs
                        double result0;
                        Console.WriteLine("Digite o valor do Pixel:");
                        double px0 = double.Parse(Console.ReadLine());
                        result0 = px0 / num;
                        Console.WriteLine("\nO valor em EM é " + result0 + " "+"em\n");break;

                    case 1://Converte Pixel em Porcentagem
                        double result1;
                        Console.WriteLine("Digite o valor do Pixel:");
                        double px1 = double.Parse(Console.ReadLine());
                        result1 = (px1 / num) * 100;
                        Console.WriteLine("\nO valor em % é " + result1 + " "+"%\n");break;

                    case 2://Converte Pixel em Points (PT)
                        double result2;
                        double pt1 = 72;
                        double pixel = 96;
                        Console.WriteLine("Digite o valor em Pixel:");
                        double px2 = double.Parse(Console.ReadLine());
                        result2 = px2 * (pt1 / pixel);
                        Console.WriteLine("O valor em Points é " + result2 + " "+"points\n");break;

                    case 3://Converte EMs em Pixel
                        double result3;
                        Console.WriteLine("Digite o valor em EM:");
                        double em0 = double.Parse(Console.ReadLine());
                        result3 = em0 * num;
                        Console.WriteLine("\nO valor em Pixel é " + result3 + " "+"pixel\n");break;

                    case 4://Converte EMs em Porcentagem %
                        double result4;
                        Console.WriteLine("Digite o valor em EM:");
                        double em1 = double.Parse(Console.ReadLine());
                        result4 = em1 * 100;
                        Console.WriteLine("\nO valor em % é " + result4 + " "+"%\n");break;

                    case 5://Encerra a aplicação
                        Environment.Exit(0);break;
                }
            }
            Console.ReadLine();
        }
    }
}
