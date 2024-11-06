using System;
namespace Aula8Exercicios {
    class Exercicio5 {

        private int[,] rotacionaMatriz(int[,] matriz) {
            int[,] matrizRotacionada = new int[4, 4];

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    matrizRotacionada[j, matriz.GetLength(0) - 1 - i] = matriz[i, j];
                }
            }

            return matrizRotacionada;
        }

        public void imprimeMatriz(int[,] matriz) {
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    System.Console.WriteLine(matriz[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }
        static void Main(string[] args) {
            int[,] matriz = new int[4,4] 
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            Exercicio5 rotacao = new Exercicio5();

            int[,] matrizRotacionada = rotacao.rotacionaMatriz(matriz);

            rotacao.imprimeMatriz(matrizRotacionada);
        }
    }
}