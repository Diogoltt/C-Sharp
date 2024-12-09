namespace Aula17Exercicio2
{
    public class Execucao
    {
        static void Main(string[] args)
        {
            Produto[] produtos = new Produto[3];
            produtos[0] = new Livro(1, 20.0, "Autor 1", 123456789);
            produtos[1] = new CompactDisc(2, 30.0, "Artista 1", "Gravadora 1");
            produtos[2] = new Livro(3, 40.0, "Autor 2", 9318942);

            foreach (Produto produto in produtos)
            {
                System.Console.WriteLine($"Código: {produto.Codigo}");
                System.Console.WriteLine($"Preço: R$ {produto.Preco:F2}");

                if (produto is Livro livro)
                {
                    System.Console.WriteLine($"Autor: {livro.Autor}");
                    System.Console.WriteLine($"ISBN: {livro.ISBN}");
                }
                else if (produto is CompactDisc cd)
                {
                    System.Console.WriteLine($"Artista: {cd.Artista}");
                    System.Console.WriteLine($"Gravadora: {cd.Gravadora}");
                }

                System.Console.WriteLine();
            }
        }
    }
}
