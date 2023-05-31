/*Desenvolva um programa que solicite ao usuário para inserir uma senha e,
em seguida, permita que o usuário tente inserir a senha até três vezes. Caso o
usuário acerte a senha, exiba uma mensagem de sucesso. Caso contrário,
exiba uma mensagem informando que a senha está incorreta. */

using System;

class Program {
  public static void Main (string[] args) {
    // variáveis
    string senha = "1234";
    int quant = 3;
    int i = 1;
   Console.Write("Por favor digite a sua senha: ");
    senha = Console.ReadLine();

    if(senha != "1234")
    {
      while (i < quant)
   {
     Console.Write("Por favor digite a sua senha: ");
    senha = Console.ReadLine();
     i++;
   }
      Console.Write("Senha incorreta");
      }  
    else {
      Console.Write("Senha correta");
    }
  }
}