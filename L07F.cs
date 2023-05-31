/*f) Crie um programa que solicite ao usuário para inserir um número inteiro
positivo e, em seguida, exiba todos os números pares entre 0 e o número
inserido. */

using System;

class Program {
  public static void Main (string[] args) {
    // variável
    int num;
    // Entrada de dados
    Console.Write("Por favor digite um número inteiro positivo: ");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Os números pares entre 0 e {0}", num);
    int i = 0;
    do 
    {
      // Saída de dados
    Console.Write(i);
    Console.Write(".");
  i+=2;
      }
    while (i <= num);
  }
}