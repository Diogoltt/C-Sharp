using System;
namespace Aula2 {
    class AreaCirculo {
        static void Teste() {
            System.Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double area = pi * (2 * raio);
            System.Console.WriteLine($"A área do círculo é: {area:F2}");
        }
    }
}
