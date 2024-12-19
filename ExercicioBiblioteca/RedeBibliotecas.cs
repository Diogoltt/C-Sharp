namespace ExercicioBiblioteca
{
    public class RedeBibliotecas
    {
        private List<Biblioteca> bibliotecas = new List<Biblioteca>();
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            bibliotecas.Add(biblioteca);
            System.Console.WriteLine($"{biblioteca.Nome} foi adicionada na rede de bibliotecas");
        }

        public void RemoverBiblioteca(Biblioteca biblioteca)
        {
            System.Console.WriteLine($"{biblioteca.Nome} foi removida da rede de bibliotecas.");
            bibliotecas.Remove(biblioteca);
        }

        public void GerenciarFuncionarios(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

    }
}