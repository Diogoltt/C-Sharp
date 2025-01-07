namespace ExerciciosEnumerate
{
    public class GerenteVendas : Empregado, IGerente
    {
        public RegiaoAtuacao Regiao { get; set; }

        public GerenteVendas(string nome, RegiaoAtuacao regiao)
        : base(nome, TipoEmpregado.GerenteVendas)
        {
            Regiao = regiao;
        }

        public void Autorizar()
        {
            System.Console.WriteLine($"Gerente de vendas {Nome} autorizou.");
        }

        public bool ConcedeAumento()
        {
            return true;
        }

        public bool AutorizaLicenca(Empregado empregado)
        {
            return true;
        }

        public override double CalcularSalario()
        {
            return base.CalcularSalario() * 2.0;
        }
    }
}