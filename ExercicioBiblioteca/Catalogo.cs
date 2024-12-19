namespace ExercicioBiblioteca
{
    public class Catalogo
    {
        private List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
            System.Console.WriteLine($"Livro {livro.Titulo} foi adicionado ao catálogo.");
        }

        public void RemoverLivro(Livro livro)
        {
            livros.Remove(livro);
            System.Console.WriteLine($"Livro {livro.Titulo} foi removido do catálogo.");
        }

        public void ConsultarLivros()
        {
            foreach (var livro in livros)
            {
                System.Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano de Publicação: {livro.AnoPublicacao}, Exemplares: {livro.ExemplaresDisponiveis}");
            }
        }
    }
}