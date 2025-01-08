namespace ExerciciosEnumerate
{
    public class Vendedor : Empregado
    {
        public Vendedor(string nome, double salario, int licencasPremioRecebidas, TipoEmpregado tipoEmpregado, StatusLicenca statusLicenca, double comissao, RegiaoAtuacao regiao)
        : base(nome, TipoEmpregado.Vendedor)
        {
            Comissao = comissao;
            Regiao = regiao;
        }

        public double Comissao { get; set; }
        public RegiaoAtuacao Regiao { get; set; }

        public override double CalcularSalario()
        {
            return Salario + (Salario * Comissao);
        }
    }
}