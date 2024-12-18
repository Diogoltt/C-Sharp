namespace Aula20_OO_Relacoes
{
    public class PortaCozinha : Porta
    {

        public PortaCozinha(string cor, double largura, double altura, double peso) : base(cor, largura, altura, peso)
        {
            
        }
        // Subscrevendo o metodo Abrir
        public override void Abrir()
        {
            System.Console.WriteLine("Porta da cozinha aberta");
        }

        // Subscrevendo o metodo Fechar
        public override void Fechar()
        {
            System.Console.WriteLine("Porta da cozinha fechada");
        }
    }
}