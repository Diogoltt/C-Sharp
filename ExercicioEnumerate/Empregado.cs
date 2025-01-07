namespace ExerciciosEnumerate
{
    public class Empregado : Pessoa
    {
        private const double SALARIO_MINIMO = 240.00;

        public Empregado(string nome, TipoEmpregado tipoEmpregado) 
        : base(nome)
        {
            Salario = SALARIO_MINIMO;
            TipoEmpregado = tipoEmpregado;
            StatusLicenca = StatusLicenca.Pendente;
        }

        public double Salario { get; set; }
        public TipoEmpregado TipoEmpregado { get; set; }
        public StatusLicenca StatusLicenca { get; set; }

        public virtual double CalcularSalario()
        {
            return Salario;
        }
    }
}