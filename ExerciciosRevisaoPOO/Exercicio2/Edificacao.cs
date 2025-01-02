namespace ExerciciosRevisaoPOO.Exercicio2
{
    public abstract class Edificacao
    {
        public double MetragemTotal { get; set; }
        public string Endereco { get; set; }
        public Engenheiro Responsavel { get; set; }
        public List<UnidadeResidencial> Unidades { get; set; }  = new List<UnidadeResidencial>();

        public Edificacao(double metragemTotal, string endereco, Engenheiro responsavel)
        {
            MetragemTotal = metragemTotal;
            Endereco = endereco;
            Responsavel = responsavel;
        }

        public abstract string DescricaoDoImovel();
    }
}