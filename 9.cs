using System;  
 class   Exercício9
{  
  static void Main() 
{
   int p,num;
   
	Console.Write("\n\n");
    Console.Write("\n\n");   
    Console.Write("Digite um número, logo sua tabuada será exibida : ");
    num= Convert.ToInt32(Console.ReadLine());   
    Console.Write("\n");
   for(p=1;p<=10;p++)
   {
     Console.Write("{0} X {1} = {2} \n",num,p,num*p);
   }
  }
}