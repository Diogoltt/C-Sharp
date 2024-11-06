using System;
namespace Aula7Exercicios {
    class Exercicio3 {

        static bool VerificaPalindromo(int[] vetor) {
            int[] novoVetor = new int[vetor.Length];
            int j = 0;
            bool palindromo = true;

            for (int i = vetor.Length - 1; i >= 0; i--) {
                novoVetor[j] = vetor[i];
                j++;
            }

            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] != novoVetor[i]) {
                    palindromo = false;
                }
            }

            return palindromo;
        }
        static void teste() {
            int[] vetor = {1, 2, 3, 3, 2, 1};
            
            bool resultado = VerificaPalindromo(vetor);

            if (resultado) {
                System.Console.WriteLine("o vetor é Palindromo");
            } else {
                System.Console.WriteLine("o vetor não é Palindromo");
            }

        }
    }
}