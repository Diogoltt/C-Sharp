namespace ExerciciosEnumerate
{
    public class GerenteProducao : Empregado, IGerente
    {
        public GerenteProducao(string nome)
        : base(nome, TipoEmpregado.GerenteProducao)
        {

        }

        public void Autorizar()
        {
            System.Console.WriteLine($"Gerente de produção {Nome} autorizou.");
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
            return Salario * 1.8;
        }
    }
}