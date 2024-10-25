using System;
namespace Aula2
{
    class AreaTriangulo {
        static void Teste() {
            System.Console.WriteLine("Digite a altura do triângulo: ");
            int altura = int.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine("Digite a base do triângulo: ");
            int b = int.Parse(Console.ReadLine()); // Converte string para int usando o Parse


            System.Console.WriteLine("A área do triângulo é " + (b * altura) / 2);        
            }
    }
}