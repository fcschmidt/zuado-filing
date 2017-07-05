using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversão_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {

            string nomeH, nomeM,idadeH, idadeM; 
            int idadeH, idadeM, soma;

            Console.WriteLine("Informe o nome do Homem");
            nomeH = (Console.ReadLine());
            Console.WriteLine("Informe a idade do Homem");
            idadeH = (Console.ReadLine());
            Console.WriteLine("Informe o nome da Mulher");
            nomeM = (Console.ReadLine());
            Console.WriteLine("Informe a idade da Mulher");
            idadeM = (Console.ReadLine());
          

            Console.WriteLine("A" + nomeM +" tem " + idadeM + "Anos");
            Console.WriteLine("O" + nomeH +" tem " + idadeH + "Anos");
            
            
            
            //int soma = Convert.ToInt16(idadeH) + Convert.ToInt16(idadeM);
            //Console.WriteLine("A Soma das idade é = " + soma);

            soma = int.Parse(idadeM)+int.Parse(idadeH);
            Console.WriteLine("A Soma das idade é = " + soma.ToString());
            
            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
