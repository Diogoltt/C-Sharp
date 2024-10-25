using System;
namespace Aula2 {
    class AreaQuadrado {
        static void Teste() {
            System.Console.WriteLine("Digite o valor do lado do quadrado: ");

            int lado = int.Parse(System.Console.ReadLine());
            
            int areaDoQuadrado = lado * lado;
            
            System.Console.WriteLine($"A área do quadrado é: {areaDoQuadrado}");
        }
    }
}