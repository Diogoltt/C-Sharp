namespace ExerciciosRevisaoPOO.Exercicio2
{
    public class Casa : Edificacao
    {
        public bool Condominio { get; set; }

        public Casa(double metragemTotal, string endereco, Engenheiro responsavel, bool condominio) : base(metragemTotal, endereco, responsavel)
        {
            Condominio = condominio;
        }

        public override string DescricaoDoImovel()
        {
            var descricao = $"Casa situada a {Endereco}.\n" +
                            $"Área total: {MetragemTotal} metros quadrados.\n" +
                            $"Responsável: Eng. {Responsavel.Nome}. CREA {Responsavel.Crea}.\n" +
                            $"Condomínio: {(Condominio ? "Sim" : "Não")}.";

            for (int i = 0; i < Unidades.Count; i++)
            {
                descricao += $"\nUnidade {i + 1}\n{Unidades[i]}";
            }

            return descricao;
        }
    }
}
