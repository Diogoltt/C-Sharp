namespace Aula17Exercicio2
{
    public class Livro : Produto
    {
        public string? Autor { get; set; }
        public long ISBN { get; set; }

        public Livro(int codigo, double preco, string autor, long isbn) : base(codigo, preco)
        {
            Autor = autor;
            ISBN = isbn;
        }

        public override void AtualizaPreco(double preco)
        {
            Preco = preco;
        }
    }
}