namespace Aula17
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Circulo circulo = new("Circulo", 5);
            circulo.CalcularArea();
            circulo.CalcularPerimetro();
            circulo.ImprimirDados();

            Retangulo retangulo = new("Retangulo", 5, 10);
            retangulo.CalcularArea();
            retangulo.CalcularPerimetro();
            retangulo.ImprimirDados();

            
        }
    }
}