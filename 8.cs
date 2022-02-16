using System;  
   class  Exercício8
   {  
    static void Main(string[] args)  
      {  
          int numero, i, p=0, rest=0;    
          Console.Write("Digite qualquer número: ");    
          numero = int.Parse(Console.ReadLine());  
          p=numero/2;    
          for(i = 2; i <= p; i++)    
          {    
           if(numero % i == 0)    
            {    
             Console.Write("O número digitado não é primo.");    
             rest=1;    
             break;    
            }    
          }    
          if (rest==0)    
           Console.Write("Você digitou um número primo.");       
     }  
   }