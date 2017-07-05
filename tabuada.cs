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
            int num, resp;
            Console.WriteLine("informe um número para tabuada");
            num = int.Parse(Console.ReadLine());
            
            // Enquanto i for menor ou igual a 10 faça.        
            for (int i = 0; i <= 10; i++)
            {
                resp = num * i;

                Console.WriteLine(num+" x "+i+" = "+resp);
            }

            Console.ReadLine();

        }
    }
}
