using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace função
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;    
            int num;  
       
            Console.WriteLine("Digite a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite c");
            c = int.Parse(Console.ReadLine());
            num = somar(a, b, c);//variavel que armazena a soma dos números
            Console.WriteLine("A soma dos números digitados é " +somar(a,b,c));
           
            Console.ReadKey();
        }     
        //função calcula a soma dos númeos digitados
        static int somar(int a, int b, int c)
        {
            int soma = a + b + c;
            return soma;
        }
        static double div(int num)
        {
            int divisão = 0;
            if (num != 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        divisão = num / i;
                        Console.WriteLine(divisão);
                       
                    }  
                }     
            }         
        }
    }
}
