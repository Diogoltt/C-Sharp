namespace ExerciciosRevisaoPOO.Exercicio3
{
    public class Utilitario : Veiculo
    {
        public bool IsFurgao { get; set; }

        public Utilitario(string modelo, double valorLocacao, double impostoLocacao, bool isFurgao) : base(modelo, valorLocacao, impostoLocacao)
        {
            IsFurgao = isFurgao;
        }

        public override double CalculaValorDiaria()
        {
            return ValorLocacao + ImpostoLocacao + (IsFurgao ? 30 : 60);
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTipo: {(IsFurgao ? "Furgão" : "Camionete")}";
        }
    }
}