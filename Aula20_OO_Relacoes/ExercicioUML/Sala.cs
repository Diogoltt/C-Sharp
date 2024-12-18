namespace Aula20_OO_Relacoes
{
    public class Sala
    {

        // Composição de entrada da porta da sala

        public PortaSala PortaSala { get; set; }
        public Porta PortaAuxiliar { get; set; }
        public double MetragemQuadrada { get; set; }

        public Sala(PortaSala portaSala, Porta portaAuxiliar, float metragemQuadrada)
        {
            PortaAuxiliar = portaAuxiliar;
            MetragemQuadrada = metragemQuadrada;
            // Relação de composição
            PortaSala = new PortaSala(portaSala.Cor, portaSala.Altura, portaSala.Largura, portaSala.Peso);
        }

        public void AbrirPortaAuxiliar()
        {
            PortaAuxiliar.Abrir();
        }
    }
}