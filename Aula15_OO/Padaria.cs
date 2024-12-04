using System;

namespace Aula15_OO
{
    public class Padaria
    {
        public string NomeAlimento;
        public double Preco;
        public string Bebidas;
        public string Doces;

        public DateTime DataValidade;

        public string encomenda()
        {
            return "O Alimento " + NomeAlimento + ", Bebida " + Bebidas + ", Doce " + Doces + ", Foram encomendados";
        }

        /*
        public double cestaCompras(string nome, double preco, string bebida, string doce, DateTime dataValidade)
        {
            this.NomeAlimento = nome;
            this.Bebidas = bebida;
            this.Doces = doce;
            this.DataValidade = dataValidade;
            this.Preco = preco;
            double total = this.Preco;
            return total;
        }
        */

        public double cestaCompras(List<(string NomeAlimento, double Preco)> itens)
        {
            double total = 0;

            foreach (var item in itens)
            {
                System.Console.WriteLine($"Item {item.NomeAlimento}, Preco: {item.Preco}");
                total += item.Preco;
            }

            return total;
        }
    }

    public class Program
    {
        public static void teste(string[] args)
        {
            Padaria padaria = new Padaria();
            padaria.NomeAlimento = "Pão";
            padaria.Preco = 10.0;
            padaria.Bebidas = "Cerveja";
            padaria.Doces = "Brigadeiro";
            padaria.DataValidade = DateTime.Now.AddDays(10);

            List<(string NomeAlimento, double Preco)> listasCompras = new List<(string NomeAlimento, double Preco)>(){
                ("Pão Francês", 5.98),
                ("Bolo Cenoura", 20.50),
                ("Coxinha", 4.50),
                ("Suco Natural", 10.20)
            };

            double total = padaria.cestaCompras(listasCompras);
            System.Console.WriteLine($"Total da cesta de compra: R${total}");
            
        }
    }
}
