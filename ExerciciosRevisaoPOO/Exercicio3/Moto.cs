namespace ExerciciosRevisaoPOO.Exercicio3
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string modelo, double valorLocacao, double impostoLocacao, int cilindrada = 125) : base(modelo, valorLocacao, impostoLocacao)
        {
            Cilindrada = cilindrada;
        }

        public override double CalculaValorDiaria() // 50 Centavos por cilindrada acima de 125
        {
            return ValorLocacao + ImpostoLocacao + (Cilindrada > 125 ? (Cilindrada - 125) * 0.5 : 0);
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCilindrada: {Cilindrada}cc";
        }
    }
}