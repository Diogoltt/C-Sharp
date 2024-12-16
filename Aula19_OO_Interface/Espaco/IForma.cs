namespace Aula19_OO_Interface
{
    public interface IForma
    {
        double CalcularArea();
        double CalcularPerimetro();

        void ExibirInformacoes()
        {
            System.Console.WriteLine("Área: " + CalcularArea());
            System.Console.WriteLine("Perímetro: " + CalcularPerimetro());
        }
    }
}