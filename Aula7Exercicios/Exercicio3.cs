using System;
namespace Aula7Exercicios {
    class Exercicio3 {
        static void teste() {
            int[] vetor = {1, 2, 3, 3, 2, 1};
            int[] novoVetor = new int[vetor.GetLength(0)];
            int j = 0;
            bool palidromo = true;

            for (int i = vetor.GetLength(0) - 1; i >= 0; i--) {
                novoVetor[j] = vetor[i];
                j++;
            }

            for (int i = 0; i < vetor.GetLength(0); i++) {
                System.Console.WriteLine(novoVetor[i]);
            }
            
            for (int i = 0; i < vetor.GetLength(0); i++) {
                if (vetor[i] != novoVetor[i]) {
                    palidromo = false;
                }
            }

            if (palidromo) {
                System.Console.WriteLine("o vetor é Palindromo");
            } else {
                System.Console.WriteLine("o vetor não é Palindromo");
            }

        }
    }
}