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
            double num1;
            double num2;
            double total;
            string operacao;
            total = 0;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());            
            Console.WriteLine("\nDigite a Operação:");
            operacao = (Console.ReadLine());
            Console.WriteLine("\nDigite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());            
                     

            if (operacao == "+") {
                total = num1 + num2; 
               }
            if (operacao == "-") {
                total = num1 - num2;
               }
            if (operacao == "*") {
                total = num1 * num2;
               }
            if (operacao == "/") {
                total = num1 / num2;
               }
            if (operacao == "") { 
                
               }

            Console.WriteLine("\nO resuldo é: " + total);

            Console.ReadKey();
            Console.ReadLine();


        }
    }
}
