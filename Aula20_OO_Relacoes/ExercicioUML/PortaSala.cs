namespace Aula20_OO_Relacoes
{
    public class PortaSala : Porta
    {
        
        public PortaSala(string cor, double altura, double largura, double peso) : base(cor, largura, altura, peso)
        {
            
        }
        public override void Abrir()
        {
            System.Console.WriteLine("Abrindo porta da Sala");
        }

        public override void Fechar()
        {
            System.Console.WriteLine("Fechando porta da sala");
        }
    }
}