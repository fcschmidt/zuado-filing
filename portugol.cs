using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace portugol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º valor:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor:");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                for (int i = 0; i < n2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("O número " + i + " é par.");
                    }
                }
            }
            else
                Console.WriteLine("Intevalo incorreto.");

            Console.ReadLine();
        }
    }
}
