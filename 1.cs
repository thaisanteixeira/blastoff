using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int i, j, k, x, y;
            
            
           
            Console.WriteLine("A seguir calcularemos a média de idade entre I, J, K, X e Y: ");
            Console.WriteLine(" ");

           
            
            Console.Write("Digite a idade de I: ");
            i = int.Parse(Console.ReadLine());
             
            Console.Write("Digite a idade de J: ");
            j = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade de K: ");
            k = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade de X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade de Y: ");
            y = int.Parse(Console.ReadLine());

           int media = (i+j+k+x+y)/5;
             Console.Write($"A média das idades é {media}");
             //Console.Write(media);
            


        }
    }
}