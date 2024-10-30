using System;
namespace Aula5 {
    class Exercicio1 {
        static void teste() {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++) {
                System.Console.WriteLine($"Insira o valor do índice[{i}] do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Ordem direta dos valores lidos: ");
            for (int i = 0; i < vetor.Length; i++) {
                System.Console.WriteLine(vetor[i]);
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Ordem inversa dos valores lidos: ");
            for (int i = vetor.Length - 1; i >= 0; i--) {
                System.Console.WriteLine(vetor[i]);
            }

        }
    }
}