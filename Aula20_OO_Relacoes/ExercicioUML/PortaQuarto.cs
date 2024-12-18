namespace Aula20_OO_Relacoes
{
    public class PortaQuarto : Porta
    {
        public PortaQuarto(string cor, double largura, double altura, double peso) : base(cor, largura, altura, peso)
        {
            
        }

        public override void Abrir()
        {
            System.Console.WriteLine("Porta do quarto aberta");
        }

        public override void Fechar()
        {
            System.Console.WriteLine("Porta do quarto fechada");
        }
    }
}