using System;
namespace Aula7Exercicios {
    class Exercicio2 {
        static void teste() {
            int[,] matriz = new int[4,4] 
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            int[] totalLinha = new int[4];

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    totalLinha[i] += matriz[i, j];
                }
            }

            for (int i = 0; i < totalLinha.GetLength(0); i++) {
                System.Console.WriteLine($"A soma dos elementos da linha {i} é: {totalLinha[i]}");
            }

        }
    }
}