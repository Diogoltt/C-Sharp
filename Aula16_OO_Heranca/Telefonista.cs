namespace Aula16_OO_Heranca
{
    public class Telefonista : Funcionario
    {
        public string EstacaoDeTrabalho;

        public Telefonista(string nome, string cpf, double salario, string estacaodetrabalho) : base(nome, cpf, salario)
        {
            this.EstacaoDeTrabalho = estacaodetrabalho;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.05;
        }

        public override void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Salario: " + Salario);
            System.Console.WriteLine("Estação de Trabalho: " + EstacaoDeTrabalho);
            System.Console.WriteLine("Bonificação: " + GetBonificacao());
        }
    }
}