namespace ExercicioBiblioteca
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set; }

        public Funcionario(string nome, string cpf, string cargo) : base(nome, cpf)
        {
            Cargo = cargo;
        }

        public void ManterCatalogo(Catalogo catalogo, Livro livro)
        {
            catalogo.AdicionarLivro(livro);
        }

        public void RealizarEmprestimo(Leitor leitor, Livro livro)
        {
            leitor.SolicitarEmprestimo(livro);
            System.Console.WriteLine($"O funcionario {Nome} emprestou o livro {livro.Titulo} para: {leitor.Nome}");
        }
    }
}