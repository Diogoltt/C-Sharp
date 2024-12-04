using System;
namespace Aula15_OO
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        // Construtor padrão
        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public Produto()
        {
            this.Nome = "sem nome";
            this.Preco = 0;
        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine("Nome: " + this.Nome);
            System.Console.WriteLine("Preço: " + this.Preco);
        }

        static void Main(string[] args)
        {
            Produto p1 = new Produto("Notebook", 2020);
            p1.ExibirInformacoes();
            
            Produto p2 = new Produto();
            p2.Nome = "Celular";
            p2.Preco = 1000;
            p2.ExibirInformacoes(); 
        }
    }
}