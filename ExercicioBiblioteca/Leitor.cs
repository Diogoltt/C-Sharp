namespace ExercicioBiblioteca
{
    public class Leitor : Usuario
    {
        public Leitor(string nome, string cpf) : base(nome, cpf){}

        public void ConsultarLivros(Biblioteca biblioteca)
        {
            biblioteca.ConsultarLivros();
        }

        public void SolicitarEmprestimo(Livro livro)
        {
            if (livro.ExemplaresDisponiveis > 0)
            {
                Console.WriteLine($"Empréstimo do livro {livro.Titulo} foi solicitado por: {Nome}");
                livro.ExemplaresDisponiveis--;
            }
        }
    }
}