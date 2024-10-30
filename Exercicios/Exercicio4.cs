using System;
using System.Diagnostics;
namespace Exercicios {
    class Exercicio4 {
        static void Main(string[] args) {
            int maior = int.MinValue;
            int menor = int.MaxValue;

            bool continuar = true;

            while(continuar) {
                System.Console.WriteLine("Digite o número: ");
                int number = int.Parse(Console.ReadLine());

                if (number == -1) {
                    continuar = false;
                }

                if (number > maior) {
                    maior = number;
                }

                if (number < menor && number != -1) {
                    menor = number;
                }

            }

            System.Console.WriteLine("O menor número digitado foi: " + menor);
            System.Console.WriteLine("O maior número digitado foi: " + maior);
        }
    }
}