using System;
namespace Aula16_OO
{
    /*
    public class Ferramentas
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public Ferramentas()
        {
            Nome = "Martelo";
            Preco = 29.90;
            Quantidade = 1;
        }

        public Ferramentas(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
    */

    public record Ferramentas (string Nome, double Preco, int Quantidade)
    {
        public double CalcularEstoque()
        {
            return Preco * Quantidade;
        }
    }
        
}