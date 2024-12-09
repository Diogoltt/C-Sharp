namespace Aula17
{
    public class Retangulo : Forma
    {
        public double Largura;
        public double Altura;

        public Retangulo(string nome, double largura, double altura) : base(nome)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            System.Console.WriteLine("Largura: " + Largura);
            System.Console.WriteLine("Altura: " + Altura);
            System.Console.WriteLine("");
        }
    }
}