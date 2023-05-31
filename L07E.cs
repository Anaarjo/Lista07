/*Crie um programa que solicite ao usuário para inserir uma sequência de
números inteiros e, em seguida, exiba a soma desses números.*/


using System;

class Program {
  public static void Main (string[] args) {
        // variáveis para o loop
        int num = 0;
        int soma = 0;
        // Enquanto o número for positivo o programa irá rodar
        while (true) {
            Console.Write("Por favor, digite um número inteiro\nou digite um número negativo para sair do programa: ");
            num = int.Parse(Console.ReadLine());
    // Se o número for negativo o programa irá parar
            if (num < 0) {
                break;
            }
      // Incremento
            soma += num;
        }
      // Saída de dados
        Console.WriteLine("A soma dos números inseridos é: {0} ", soma);

  }
}