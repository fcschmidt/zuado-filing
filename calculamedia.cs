using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculamedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Primeira Nota:");
            double pNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Segunda Nota:");
            double sNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Terceira Nota:");
            double tNota = double.Parse(Console.ReadLine());

            double media = (pNota + sNota + tNota) / 3;
            double exame = (12 - media);


   
                if (media >= 0.0)
                    if (media < 3.0)
                        Console.WriteLine("Reprovado sua nota foi = " + media);
                         
           
                if (media >= 7.0)
                    if (media <= 10.0)
                        Console.WriteLine("Aprovado sua nota foi = " + media);
                          
 
              if (media >= 3.0)
                    if (media < 7.0)
                        Console.WriteLine("Exame, nota necessária para aprovação = " + exame);
            

                Console.ReadKey();
            }
        }
    }

            
                 




         

 
            
               

            


             

  
