using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace latas
{
    class Program
    {
        static void Main(string[] args)
        {
            int area;
            int latas;
            
            Console.WriteLine("Digite o tamanho da área a ser pintada:");
            area = int.Parse(Console.ReadLine());
            int valor = 0;
            if (area % 54 != 0)
            { 
                latas = (area / 54) + 1;

            }
            else{
                latas = area / 54;
                valor = latas * 80;
            }
            Console.WriteLine("Necessário"+latas+"latas"+","+"por R$"+valor);
            Console.ReadLine();
        }
    }
}
