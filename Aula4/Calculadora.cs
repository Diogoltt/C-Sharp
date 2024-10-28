using System;
namespace Aula4 {
    class Calculadora {
        static void Main(string[] args) {

            System.Console.WriteLine("Digite o número a ser calculado: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++) {
                System.Console.WriteLine($"{number} * {i} = {number * i}");
            }

            System.Console.WriteLine("");

            int j = 0;
            while (j <= 10) {
                System.Console.WriteLine($"{number} * {j} = {number * j}");
                j++;
            }

            System.Console.WriteLine("");

            int k = 0;
            do {
                System.Console.WriteLine($"{number} * {k} = {number * k}");
                k++;
            } while (k <= 10);
        }
    }
}