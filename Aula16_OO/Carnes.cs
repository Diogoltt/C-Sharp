using System;
namespace Aula16_OO
{
    public class Carnes
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public Carnes()
        {
            Nome = "Picanha";
            Preco = 50.50;
            Quantidade = 1;
        }

        public Carnes(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public double CalcularEstoque()
        {
            return Preco * Quantidade;
        }
    }
}