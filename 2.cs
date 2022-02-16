using System;

namespace program
{
class exercicio2
{
    static void Main(string[] args)
        {
            int dist;
            double consumo;

            Console.WriteLine("Digite a distância percorrida: ");
            dist = int.Parse(Console.ReadLine());

            consumo = dist/7; //considerando um opala

            Console.WriteLine("A quantidade gasta de combustível é: {0:N}", consumo);
        }

    }
}
