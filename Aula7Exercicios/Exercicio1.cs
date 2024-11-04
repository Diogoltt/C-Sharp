using System;
namespace Aula7Exercicios {
    class Exercicio1 {
        static void teste() {
            int[] vetor = new int[10];
            int media = 0;

            for (int i = 0; i < vetor.GetLength(0); i++) {
                System.Console.WriteLine($"Insira o valor do índice[{i}] do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
                media += vetor[i];
            }

            media = media / vetor.GetLength(0);
            System.Console.WriteLine(media);

        }
    }
}