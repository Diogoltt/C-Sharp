namespace Aula17
{
    public abstract class Forma
    {
        public string? Nome;

        public Forma(string nome)
        {
            Nome = nome;
        }

        
        // Métodos abstratos não possuem corpo e devem ser implementados nas classes filhas
        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

        public virtual void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Área: " + CalcularArea());
            System.Console.WriteLine("Perímetro: " + CalcularPerimetro());
        }

    }
}