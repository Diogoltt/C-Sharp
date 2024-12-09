namespace Aula17Exercicio
{
    public abstract class Empregado
    {
        public string? Nome;
        public string? Sobrenome;
        public string? Cpf;

        public Empregado(string nome, string sobrenome, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
        }

        public abstract double Vencimento();

        public virtual void ExibirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Sobrenome: " + Sobrenome);
            System.Console.WriteLine("CPF: " + Cpf);
            System.Console.WriteLine("Vencimento: " + Vencimento());
        }
    }
}