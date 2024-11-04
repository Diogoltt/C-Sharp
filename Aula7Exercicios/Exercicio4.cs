using System;
namespace Aula7Exercicios {
    class Exercicio4 {
        static void teste() {
            int[,] matriz = new int[4,4] 
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            int diagonalPrincipal = 0; 
            int diagonalSecundaria = 0;

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    if (i == j) {
                        diagonalPrincipal += matriz[i, j];
                    }

                    if (i + j == matriz.GetLength(0) - 1) {
                        diagonalSecundaria += matriz[i, j];
                    }
                }
            }

            System.Console.WriteLine(diagonalPrincipal);
            System.Console.WriteLine(diagonalSecundaria);
        }
    }
}