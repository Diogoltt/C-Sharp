namespace ExerciciosRevisaoPOO.Exercicio2
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}