namespace ExerciciosRevisaoPOO.Exercicio3
{
    public class CarroPasseio : Veiculo
    {
        public string Categoria { get; set; }

        public CarroPasseio(string modelo, double valorLocacao, double impostoLocacao, string categoria) : base(modelo, valorLocacao, impostoLocacao)
        {
            Categoria = categoria;
        }

        public override double CalculaValorDiaria()
        {
            double Adicional = Categoria switch
            {
                "A" => 100,
                "B" => 50,
                "C" => 20,
                _ => 0
            };
            return ValorLocacao + ImpostoLocacao + Adicional;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCategoria: {Categoria}";
        }
    }
}