using System;
namespace Aula7Exercicios {
    class Exercicio5 {
        static void Main(string[] args) {
            int[,] matriz = new int[4,4] 
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            int[,] matrizRotacionada = new int[4, 4];

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    matrizRotacionada[j, matriz.GetLength(0) - 1 - i] = matriz[i, j];
                }
                System.Console.WriteLine();
            }

            for (int i = 0; i < matrizRotacionada.GetLength(0); i++) {
                for (int j = 0; j < matrizRotacionada.GetLength(1); j++) {
                    System.Console.WriteLine(matrizRotacionada[i, j] + " ");
                }
                System.Console.WriteLine();
            }

        }
    }
}