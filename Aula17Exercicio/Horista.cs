namespace Aula17Exercicio
{
    public class Horista : Empregado
    {
        public double PrecoHora;
        public double HorasTrabalhadas;

        public Horista(string nome, string sobrenome, string cpf, double precohora, double horastrabalhadas) : base(nome, sobrenome, cpf)
        {
            PrecoHora = precohora;
            HorasTrabalhadas = horastrabalhadas;
        }

        public override double Vencimento()
        {
            return PrecoHora * HorasTrabalhadas;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            System.Console.WriteLine("Preço Hora: " + PrecoHora);
            System.Console.WriteLine("Horas Trabalhadas: " + HorasTrabalhadas);
        }
    }
}