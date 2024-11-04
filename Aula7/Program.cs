using System;
namespace Aula7 {
    class Program {
        static void Main(string[] args) {
            // Matriz Tridimensional
            // Na tridimensional, há 3 índices
            // 1: linha
            // 2: coluna
            // 3: profundidade

            int[,,] matriz3D = new int[2, 2, 2] {
                {
                    {1, 2},
                    {3, 4}
                },
                {
                    {5, 6},
                    {7, 8}
                }
            };

            for (int i = 0; i < matriz3D.GetLength(0); i++) {
                for (int j = 0; j < matriz3D.GetLength(1); j++) {
                    for (int k = 0; k < matriz3D.GetLength(2); k++) {
                        System.Console.WriteLine($"[{i}, {j}, {k}] = {matriz3D[i, j, k]}");
                    }
                }
            }
            
            /*
            System.Console.WriteLine(matriz3D[0,0,0]);
            System.Console.WriteLine(matriz3D[1,1,1]);
            System.Console.WriteLine(matriz3D[1,0,1]);
        
            matriz3D[1,1,1] = 100;
            System.Console.WriteLine(matriz3D[1,1,1]);
            */

            for (int i = 0; i < matriz3D.GetLength(0); i++) {
                for (int j = 0; j < matriz3D.GetLength(1); j++) {
                    for (int k = 0; k < matriz3D.GetLength(2); k++) {
                        matriz3D[i,j,k] += matriz3D[i,j,k];
                    }
                }
            }
            
            /*
            for (int i = 0; i < matriz3D.GetLength(0); i++) {
                for (int j = 0; j < matriz3D.GetLength(1); j++) {
                    for (int k = 0; k < matriz3D.GetLength(2); k++) {
                        System.Console.WriteLine($"[{i}, {j}, {k}] = {matriz3D[i, j, k]}");
                    }
                }
            }
            */

            foreach (int item in matriz3D) {
                System.Console.WriteLine(item);
            }

        }
    }
}