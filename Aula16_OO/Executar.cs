using System;
using System.Security.Cryptography.X509Certificates;

namespace Aula16_OO
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Instanciar os construtores com parâmetros
            Carnes car = new Carnes("Picanha", 50.0, 10);

            Ferramentas fer = new Ferramentas("Martelo", 20.0, 5);

            Laticinios lat = new Laticinios("Leite", 5.0, 2);

            Limpeza limp = new Limpeza("Vassoura", 19.90, 3);

            Petiscos petiscos = new Petiscos("Queijo", 2.50, 3);

            System.Console.WriteLine($"Nome: {fer.Nome}");
            System.Console.WriteLine($"Preço: {fer.Preco}");
            System.Console.WriteLine($"Quantidade: {fer.Quantidade}");
            System.Console.WriteLine($"Valor Estoque: {fer.CalcularEstoque():F2}");
            System.Console.WriteLine("");

            System.Console.WriteLine($"Nome: {car.Nome}");
            System.Console.WriteLine($"Preço: {car.Preco}");
            System.Console.WriteLine($"Quantidade: {car.Quantidade}");
            System.Console.WriteLine($"Valor Estoque: {car.CalcularEstoque():F2}");
            System.Console.WriteLine("");

            System.Console.WriteLine($"Nome: {lat.Nome}");
            System.Console.WriteLine($"Preço: {lat.Preco}");
            System.Console.WriteLine($"Quantidade: {lat.Quantidade}");
            System.Console.WriteLine($"Valor Estoque: {lat.CalcularEstoque():F2}");
            System.Console.WriteLine("");

            System.Console.WriteLine($"Nome: {limp.Nome}");
            System.Console.WriteLine($"Preço: {limp.Preco}");
            System.Console.WriteLine($"Quantidade: {limp.Quantidade}");
            System.Console.WriteLine($"Valor Estoque: {limp.CalcularEstoque():F2}");
            System.Console.WriteLine("");

            System.Console.WriteLine($"Nome: {petiscos.Nome}");
            System.Console.WriteLine($"Preço: {petiscos.Preco}");
            System.Console.WriteLine($"Quantidade: {petiscos.Quantidade}");
            System.Console.WriteLine($"Valor Estoque: {petiscos.CalcularEstoque():F2}");
            System.Console.WriteLine("");

            // Maior valor do estoque

            double maiorValor = Math.Max(car.CalcularEstoque(),
                Math.Max(limp.CalcularEstoque(),
                    Math.Max(petiscos.CalcularEstoque(),
                        Math.Max(lat.CalcularEstoque(),
                            fer.CalcularEstoque()))));

            System.Console.WriteLine($"Maior valor do estoque: {maiorValor}");
        }
    }
}
