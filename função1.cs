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
            int numero = 0, resultado;
            Console.Title = "Fatorial dos Inteiros de 0 a 15";
            while (numero <= 15)
            {
                resultado = fatorial(numero);
                Console.WriteLine("\n{0}! = {1}", numero, resultado);
                numero++;
            }
            Console.ReadKey();
            return;
        }
        static int fatorial(int n)
        {
            int fat = 1;
            int cont = n;
            while (cont > 0)
            {
                fat = fat * cont;
                cont--;
            }
            return fat;
        }


    }
}
