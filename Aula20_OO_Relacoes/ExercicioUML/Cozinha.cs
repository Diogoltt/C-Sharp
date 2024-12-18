namespace Aula20_OO_Relacoes
{
    public class Cozinha
    {
        // Agregação com o objeto cozinha

        public PortaCozinha PortaCozinha { get; set; }
        public bool Americana { get; set; }
        public float MetragemQuadrada { get; set; }

        // Não instanciar porta cozinha, p manter relação de agregação

        // Construtor
        public Cozinha(bool americana, float metragemQuadrada)
        {
            Americana = americana;
            MetragemQuadrada = metragemQuadrada;
        }

    }
}