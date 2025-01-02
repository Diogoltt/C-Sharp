namespace ExerciciosRevisaoPOO.Exercicio3
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public double ValorLocacao { get; set; }
        public double ImpostoLocacao { get; set; }

        public Veiculo(string modelo, double valorLocacao, double impostoLocacao)
        {
            Modelo = modelo;
            ValorLocacao = valorLocacao;
            ImpostoLocacao = impostoLocacao;
        }

        public abstract double CalculaValorDiaria();

        public override string ToString()
        {
            return $"\nModelo: {Modelo}\nValor Base: R${ValorLocacao:F2}\nImposto: R${ImpostoLocacao:F2}";
        }
    }
}