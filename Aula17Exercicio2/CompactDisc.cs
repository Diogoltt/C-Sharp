namespace Aula17Exercicio2
{
    public class CompactDisc : Produto
    {
        public string? Artista { get; set; }
        public string? Gravadora { get; set; }

        public CompactDisc(int codigo, double preco, string artista, string gravadora) : base(codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }

        public override void AtualizaPreco(double preco)
        {
            Preco = preco;
        }

    }
}