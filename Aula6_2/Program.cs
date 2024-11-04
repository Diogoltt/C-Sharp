using System;
namespace Aula6_2 {
    
    class Program {
        static void teste() {
            int[,] matriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int[,] transposta = new int[3, 3];

            for (int i = 0; i < transposta.GetLength(0); i++) {
                for (int j = 0; j < transposta.GetLength(1); j++) {
                    transposta[i, j] = matriz[j, i];
                }
            }

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    System.Console.WriteLine(transposta[i, j] + " ");
                }
                System.Console.WriteLine();
            }

        }
    }
}