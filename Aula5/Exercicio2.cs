using System;
namespace Aula5 {
    class Exercicio2 {
        static void Main(String[] args) {
            int[] vetor = new int[10];
            for (int i = 0; i < vetor.Length; i++) {
                System.Console.WriteLine($"Digite um número para o índice [{i}] do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int maior = vetor[0];
            int menor = vetor[0];

            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] > maior) {
                    maior = vetor[i];
                }

                if (vetor[i] < menor) {
                    menor = vetor[i];
                }
            }

            System.Console.WriteLine("O maior valor do vetor é: " + maior);
            System.Console.WriteLine("O menor valor do vetor é: " + menor);
        }
    }
}