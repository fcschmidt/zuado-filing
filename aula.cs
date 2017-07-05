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
            Console.WriteLine("Digite o valor de x");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de z");
            double z = double.Parse(Console.ReadLine());


           
            {
                bool x = true;
                bool y = true;
                bool z = true;
                {
                    if (x = y)
                        if (y = z)
                            Console.WriteLine("O Triângulo é Equilátero");

                    if (x != y)
                        if (y = z)
                            Console.WriteLine("O Triângulo é Isosceles");

                    if (x != y)
                        if (y != z)
            
                            Console.WriteLine("O Triângulo é Escaleno");


                    Console.ReadLine();
                }



            }


        }
    }
}
























