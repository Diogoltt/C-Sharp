using System;
namespace Aula8 {
    class Program {       
        static int soma(int a, int b) {
            return a + b;
        }

        static void imprimir(string texto) {
            System.Console.WriteLine(texto);
        }

        static double multiplicacao(double x, double y, double z) {
            return x * y * z;
        }

        static int somaVetor(int[] vetor) {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++) {
                soma += vetor[i];
            } 
            return soma;
        }

        static int somaMatriz(int[,] matriz) {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    soma += matriz[i,j];
                }
            }
            return soma;
        }

        
        static void teste() {
            /*
            int a = 10;
            int b = 20;
            int resultado = soma(a, b);
            System.Console.WriteLine($"a soma de {a} + {b} é igual a: {resultado}");

            imprimir("Hello, World!");
        
            double x = 10;
            double y = 20;
            double z = 2;

            double resultado2 = multiplicacao(x, y, z);
            System.Console.WriteLine($"A multiplicação de {x}, {y} e {z} é: {resultado2}");

            double resultado3 = multiplicacao(30, 2, 2);
            System.Console.WriteLine($"Resultado: {resultado3}");

            int[] vet = {1, 2, 3, 4, 5};
            int resultadoSomaVetor = somaVetor(vet);
            System.Console.WriteLine($"O resultado da soma dos valores do vetor é: {resultadoSomaVetor}");
            
            */

            int[,] matriz = 
            { 
                {1, 2, 3}, 
                {4, 5, 6}
            };

            int resultadoSomaMatriz = somaMatriz(matriz);
            System.Console.WriteLine($"O resultado da soma dos elementos da matriz é: {resultadoSomaMatriz}");

        }
    }
}