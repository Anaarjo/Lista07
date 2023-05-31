/* Desenvolva um programa que solicite o usuário para inserir um número inteiro e,em seguida, exiba a tabuada desse número até o número 10. */
using System;

class Program {
  public static void Main (string[] args) {
    int j,n;
   
	Console.Write("\n\n");
    Console.Write("Display the multiplication table:\n");
    Console.Write("-----------------------------------");
    Console.Write("\n\n");   

   Console.Write("Input the number (Table to be calculated) : ");
   n= Convert.ToInt32(Console.ReadLine());   
   Console.Write("\n");
   for(j=1;j<=10;j++)
   {
     Console.Write("{0} X {1} = {2} \n",n,j,n*j);
   }
  }
}


/*Desenvolva um programa que solicite ao usuário para inserir um número
			 inteiro e, em seguida, exiba a tabuada desse número até o número 10.*/
			
			int n1;
			
			Console.WriteLine("Digite um numero inteiro de 1 ate 10");
			n1 = int.Parse(Console.ReadLine());
			int i  = 1;
			int j;
			while ( i <= 10)
			{	j=n1*i;
				Console.WriteLine("A multiplicação de {0} x {1} = {2}", n1,i, j);
				i++;
				
				
			}