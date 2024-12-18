namespace Aula20_OO_Relacoes
{
    public class Quarto
    {
        // Propriedades do Quarto
        public PortaQuarto PortaQuarto { get; set; }
        public bool Banheiro { get; set; }
        public double MetragemQuadrada { get; set; }

        // Construtor, terá relação de composição com PortaQuarto
        public Quarto(bool banheiro, double metragemQuadrada)
        {
            Banheiro = banheiro;
            MetragemQuadrada = metragemQuadrada;
            // Necessário instanciar a porta do quarto para ter relação de Composição
            PortaQuarto = new PortaQuarto("Branca", 0.80, 2.10, 10.0);
        }
    }
}