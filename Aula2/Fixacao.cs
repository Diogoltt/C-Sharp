using System;
using System.Globalization;
namespace Aula2 {
    class Fixacao {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            
            System.Console.WriteLine("Quantos quartos tem na sua casa?");
            int qntQuartos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
        
            System.Console.WriteLine($"O nome é: {nome}");
            System.Console.WriteLine($"Quantidade de quartos: {qntQuartos}");
            System.Console.WriteLine($"O preço do produto é: {preco.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}