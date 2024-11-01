using System;
namespace Aula6 {
    class Exercicio1 {
        static void Main(string[] args) {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++) {
                System.Console.WriteLine($"Digite o valor para o índice [{i}] do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            
            System.Console.WriteLine("Ordem dos valores lidos: ");
            for (int i = 0; i < vetor.Length ; i++) {
                System.Console.WriteLine(vetor[i]);
            }
            System.Console.WriteLine((""));

            System.Console.WriteLine("Ordem inversa dos valores lidos: ");
            for (int i = vetor.Length -1 ; i >= 0; i--) {
                System.Console.WriteLine(vetor[i]);
            }
        }
    }

    class Exercicio2 {
        static void Main (string[] args) {
            int[] vetor = new int[10];
            int maior = int.MinValue;
            int menor = int.MaxValue;
            
            for (int i = 0; i < vetor.Length; i++) {
                System.Console.WriteLine($"Digite o valor {i} do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

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

    class Exercicio3 {
        static void Main(string[] args) {
            
            int maior = int.MaxValue;
            int menor = int.MinValue;

            int[,] matriz = new int[4,4];
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    System.Console.WriteLine($"Digite o valor da posição [{i},{j}] da matriz: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }


        }
    }
}