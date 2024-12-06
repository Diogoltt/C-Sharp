using System;
namespace Aula16_OO
{
    public class Limpeza
    {
        public string? Nome;

        public double Preco;

        public int Quantidade;

        public Limpeza()
        {
            Nome = "Vassoura";
            Preco = 20.0;
            Quantidade = 2;
        }

        public Limpeza(string nome, double preco, int quantidade)
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