namespace ExerciciosRevisaoPOO.Exercicio2
{
    public class Predio : Edificacao
    {
        public string Nome { get; set; }
        public int NumAndares { get; set; }
        public int ApPorAndar { get; set; }

        public Predio(string nome, double metragemTotal, string endereco, Engenheiro responsavel, int numAndares, int apPorAndar) : base(metragemTotal, endereco, responsavel)
        {
            Nome = nome;
            NumAndares = numAndares;
            ApPorAndar = apPorAndar;
        }

        public override string DescricaoDoImovel()
        {
            var descricao = $"{Nome}.\n" +
            $"Situado a {Endereco}.\n" +
            $"Área total: {MetragemTotal} metros quadrados.\n" +
            $"Responsável: Eng. {Responsavel.Nome}. CREA {Responsavel.Crea}.\n" +
            $"Número de Andares: {NumAndares}.\n" +
            $"Número de Apartamentos por andar: {ApPorAndar}.";

            for (int i = 0; i < Unidades.Count; i++)
            {
                descricao += $"\nUnidade {i + 1}\n{Unidades[i]}";
            }

            return descricao;
        }
    }
}