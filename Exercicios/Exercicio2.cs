using System;
namespace Exercicios {
    class Exercicio2 {
        static void teste() {
            System.Console.WriteLine("Digite uma palavra: ");
            string senha = Console.ReadLine();
            if (senha == "Digix") {
                System.Console.WriteLine("Acesso autorizado");
            }
            else {
                System.Console.WriteLine("Acesso negado");
            }
        }
    }
}