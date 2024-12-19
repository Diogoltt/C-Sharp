namespace ExercicioBiblioteca
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
    }
}