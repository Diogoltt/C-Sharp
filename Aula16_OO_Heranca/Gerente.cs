namespace Aula16_OO_Heranca
{
    public class Gerente : Funcionario
    {
        public string Setor;

        public Gerente(string nome, string cpf, double salario, string setor) : base(nome, cpf, salario)
        {
            // Base é usado para chamar o construtor da classe pai
            this.Setor = setor;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.15;
        }

        public void GerenciarEquipe()
        {
            System.Console.WriteLine("Gerenciado equipe");
        }

        public override void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Salario: " + Salario);
            System.Console.WriteLine("Setor: " + Setor);
            System.Console.WriteLine("Bonificação: " + GetBonificacao());
        }
    }
}