namespace ExercicioBiblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }   
        public int AnoPublicacao { get; set; }
        public int ExemplaresDisponiveis { get; set; }

        public Livro(string titulo, string autor, int anoPublicacao, int exemplaresDisponiveis)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            ExemplaresDisponiveis = exemplaresDisponiveis;
        }
    }
}