using System;
namespace Exercicios {
    class Exercicio1 {
        static void teste() {
            int maior = int.MinValue;
            int menor = int.MaxValue;
            for (int i = 1; i <= 10; i++) {
                System.Console.WriteLine($"Digite o número {i}: ");
                
                int number = int.Parse(Console.ReadLine());
                
                if (number > maior) {
                    maior = number;
                }

                if (number < menor) {
                    menor = number;
                }            
            }

            System.Console.WriteLine("O menor número digitado foi: " + menor);
            System.Console.WriteLine("O maior número digitado foi: " + maior);
        }
    }
}