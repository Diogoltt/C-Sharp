namespace ExerciciosRevisaoPOO.Exercicio2
{
    public class UnidadeResidencial
    {
        public double MetragemUnidade { get; set; }
        public int NumQuartos { get; set; }
        public int NumBanheiros { get; set; }
        public Pessoa Proprietario { get; set; }

        public UnidadeResidencial(double metragemUnidade, int numQuartos, int numBanheiros, Pessoa proprietario)
        {
            MetragemUnidade = metragemUnidade;
            NumQuartos = numQuartos;
            NumBanheiros = numBanheiros;
            Proprietario = proprietario;
        }

        public override string ToString()
        {
            return $"Propriedade de {Proprietario.Nome}.\n" + $"Possui {MetragemUnidade} metros quadrados, {NumQuartos} Quartos, {NumBanheiros} Banheiros.";
        }
    }
}