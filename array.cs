using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            int totaldivisores = 0;
            for (int i = 2; i < numero; i++) {
                if (numero % i == 0)
                    totaldivisores++;
              
            }

          
        }
    }
}
