namespace Aula17Exercicio
{
    public class Assalariado : Empregado
    {
        public double Salario;
        
        public Assalariado(string nome, string sobrenome, string cpf, double salario) : base(nome, sobrenome, cpf)
        {
            Salario = salario;
        }

        public override double Vencimento()
        {
            return Salario;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            System.Console.WriteLine("Salario: " + Salario);
            System.Console.WriteLine("");
        }
    }
}