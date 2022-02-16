using System;
  
  {
            double i;
            double num; 
            double fatorial;
            Console.WriteLine("Informe o número");
            num = double.Parse(Console.ReadLine());

            fatorial = num;
            for (i = num - 1; i >= 1; i--)
            {
                Console.WriteLine($"{fatorial} * {i}");

                fatorial = fatorial * i;

                Console.WriteLine($"i={i}");
                Console.WriteLine($"fatorial={fatorial}");
                Console.WriteLine("  ");
            }
            Console.WriteLine($"\n O fatorial correspondente a esse número é {fatorial} ");
            Console.ReadLine();

 }