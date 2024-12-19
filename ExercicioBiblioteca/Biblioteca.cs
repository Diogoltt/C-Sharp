using System.Data.Common;

namespace ExercicioBiblioteca
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        private Catalogo catalogo;
        private List<Funcionario> funcionarios = new List<Funcionario>();
    
        public Biblioteca(string nome)
        {
            Nome = nome;
            catalogo = new Catalogo(); // Composição
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
            System.Console.WriteLine($"Funcionário {funcionario.Nome} foi adicionado na biblioteca {Nome}");
        }

        public void RemoverFuncionario(Funcionario funcionario)
        {
            funcionarios.Remove(funcionario);
            System.Console.WriteLine($"Funcionário {funcionario.Nome} foi removido da biblioteca {Nome}");
        }

        public void ConsultarLivros()
        {
            catalogo.ConsultarLivros();
        }

        public void AdicionarLivroAoCatalogo(Funcionario funcionario, Livro livro)
        {
            if (funcionarios.Contains(funcionario))
            {
                funcionario.ManterCatalogo(catalogo, livro);
            }
        }
    }
}