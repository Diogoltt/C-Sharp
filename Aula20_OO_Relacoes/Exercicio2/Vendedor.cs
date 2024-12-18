namespace Aula20_OO_Relacoes
{
    public class Vendedor : Funcionario
    {
        public EquipeVenda Equipe { get; set; }
        public Vendedor(string nome, DateTime nascimento, string cpf, Endereco endereco, EquipeVenda equipe) : base(nome, nascimento, cpf, endereco)
        {
            Equipe = equipe;
        }

        public double GetSalario()
        {
            return 3000.00;
        }
    }
}