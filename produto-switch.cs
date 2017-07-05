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
            int op = 0;
            double valor = 0;
            Console.WriteLine("Digite o Valor do Produto");
            valor = double.Parse(Console.ReadLine());
            double vfinal = valor;

            if (valor < 500)
            {
                valor = valor * 1;
                Console.WriteLine("Valor do desconto dado é: R$" + (valor - valor));
            }
            else if (valor >= 500 && valor < 1000)
            {
                valor = valor * 0.1;
                Console.WriteLine("Valor do desconto dado é: R$" + valor);
            }
            else if (valor >= 1000 && valor < 2000)
            {
                valor = valor * 0.15;
                Console.WriteLine("Valor do desconto dado é: R$" + valor);
            }
            else if (valor > 2000)
            {
                valor = valor * 0.16;
                Console.WriteLine("Valor do desconto dado é: R$" + valor);
            }

            Console.WriteLine("\nEscolha uma opção de pagamento:");
            Console.WriteLine("1 - Cheque sem desconto");
            Console.WriteLine("2 - Dinheiro, desconto de 5%");
            Console.WriteLine("3 - Cartão Acréscimo de 4%");
            op = int.Parse(Console.ReadLine());
            double valor2 = valor;
            

            if (op == 1)
            {
                valor2 = valor * 1;
                Console.WriteLine("Valor do desconto dado é: R$" + valor);
            }
            else if (op == 2)
            {
                valor = valor * 0.05;
                Console.WriteLine("Valor do desconto dado é: R$" + valor);
            }
            else if (op == 3)
            {
                valor = valor * 0.04;
                Console.WriteLine("Valor do desconto dado é: R$" + valor);
            }
            else {
                Console.WriteLine("Opção invalida");
            }
            Console.WriteLine("\nO valor final a paga é: R$" + valor);




            Console.ReadLine();
        }

    }
}
