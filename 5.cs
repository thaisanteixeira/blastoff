using System;
 class exercício5 {
        static void Main(string[] args) {
           
         Console.WriteLine("Digite dois números separados por espaço, por favor");
           string[] valores = Console.ReadLine().Split(' ');
           int A = int.Parse(valores[0]);
           int B = int.Parse(valores[1]);
         if (A % B  == 0 || B % A == 0) {
         Console.WriteLine("Os números digitados são múltiplos.");
         }
         else {
               Console.WriteLine("Os números digitados não são múltiplos.");
           }
      }
 }