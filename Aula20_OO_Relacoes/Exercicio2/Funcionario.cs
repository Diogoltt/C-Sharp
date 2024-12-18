namespace Aula20_OO_Relacoes
{
    public class Funcionario
    {
        public string? Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string? CPF { get; private set; }
        public Endereco? Endereco { get; private set; }

        public Funcionario(string nome, DateTime nascimento, string cpf, Endereco endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            CPF = cpf;
            Endereco = endereco;
        }

        public string? GetNome() => Nome;
        
        public DateTime GetNascimento() => Nascimento;

        public string? GetCpf() => CPF;

        public Endereco? GetEndereco() => Endereco;
    }
}