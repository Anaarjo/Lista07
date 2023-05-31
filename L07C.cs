/*Crie um programa que solicite ao usuário para inserir números inteiros até
que um número negativo seja inserido. Em seguida, exiba a soma dos
números inseridos (excluindo o número negativo).
*/


using System;

class Program {
  public static void Main (string[] args) {
    int i = 1;
   
    while (i <= 3)

      {
        //Entrada de dados
           Console.Write("Digite o 1º valor: ");
          int n1 = Convert.ToInt32(Console.ReadLine());
           Console.Write("Digite o 1º valor: ");
          int n2 = Convert.ToInt32(Console.ReadLine());
        // Cálculo da soma 
          int s = n1+ n2;
        // Resultado e saída de dados
           Console.WriteLine("A soma é igual a {0}.", Math.Abs(s));
        
        // Incremento de + 1
           i++;
       
    }
    
  }
}