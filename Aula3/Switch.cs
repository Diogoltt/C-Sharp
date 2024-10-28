using System;
namespace Aula3 {
    class Switch {
        static void teste() {
            System.Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            switch(idade) {
                case >= 18:
                    System.Console.WriteLine("Maior de idade!");
                    break;
                case >= 15 and < 18:
                    System.Console.WriteLine("Adolescente");
                    break;
                case > 3 and < 15:
                    System.Console.WriteLine("Criança");
                    break;
                case > 0 and <= 3:
                    System.Console.WriteLine("Bebê");
                    break; 
                default:
                    System.Console.WriteLine($"A idade da pessoa é {idade}.");
                    break;
            }
        }
    }
}