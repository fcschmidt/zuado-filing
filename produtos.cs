using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace produtos
{
    class Program
    {
        static void Main(string[] args)
        {

            double op = 0;
            double ch = 0;
            double di = 0;
            double ca = 0;
            double valor = 0;

            ch = valor * 0;
            di = valor * 0.05;
            ca = valor * 0.04;
            
            Console.WriteLine("Digite o valor do Produto: R$");
            valor = double.Parse(Console.ReadLine());

            {if ( valor == 0)
                Console.WriteLine(" O valor não pode ser 0, digite outro valor");

            }// aplicar uma variavel que retorne novamenta para pedir o valor
     

            Console.WriteLine("\nEscolha a forma de Pagamento, Opções:");
            Console.WriteLine(" 1 - Cheque sem Desconto");
            Console.WriteLine(" 2 - Dinheiro 5% de Desconto");
            Console.WriteLine(" 3 - Cartão Acréscimo de 4%");
            
            op = double.Parse(Console.ReadLine());
            ch = double.Parse("");


            if (op == 1 || op ==  2 || op == 3)
            {
                if () 
                {
                    Console

            }

            }
       

          
         
           
            {
                Console.ReadLine();
            }

        }
        
    }
}
