namespace Aula16_ExercicioAnimal
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Cobra cobraVenenosa = new Cobra(true, true);
            cobraVenenosa.Alimento();
            Cobra cobra = new Cobra(true, false);
            Javali javali = new Javali(true, true);
            System.Console.WriteLine(javali.GetVelocidadeMax()); 
            System.Console.WriteLine(javali.Selvagem);
            System.Console.WriteLine(cobra.Venenosa);            
        }
    }
}