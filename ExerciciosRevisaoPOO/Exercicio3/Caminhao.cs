namespace ExerciciosRevisaoPOO.Exercicio3
{
    public class Caminhao : Veiculo
    {
        public int NumEixos { get; set; }

        public Caminhao(string modelo, double valorLocacao, double impostoLocacao, int numEixos) : base(modelo, valorLocacao, impostoLocacao)
        {
            NumEixos = numEixos;
        }

        public override double CalculaValorDiaria()
        {
            return ValorLocacao + ImpostoLocacao + (NumEixos * 50);
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNúmero de eixos: {NumEixos}";
        }
    }
}