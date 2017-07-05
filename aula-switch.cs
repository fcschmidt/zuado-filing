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
            // Aula sobre SWITCH
            Console.WriteLine("Digite uma nota:");
            int nota = int.Parse(Console.ReadLine());

            switch (nota)
            {
                case 6:
                    Console.WriteLine("OK");break;

                case 7:
                    Console.WriteLine("BOM");break;

                case 8:
                    Console.WriteLine("Muito Bom");break;

                default:

                    if (nota < 6)
                        Console.WriteLine("Reprovado");

                      else if (nota > 8)
                        Console.WriteLine("Otimo");
                    break;
                    
            }
            Console.ReadLine();
        }
    }
}
