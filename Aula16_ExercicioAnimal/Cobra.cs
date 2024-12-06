namespace Aula16_ExercicioAnimal
{
    public class Cobra : Animal
    {
        public bool Venenosa;

        public Cobra(bool vivo, bool venenosa) : base(vivo)
        {
            this.Venenosa = venenosa;
        }

        public void Alimento()
        {
            System.Console.WriteLine("Cobra se alimentando");
        }

        public void SetVenenosa()
        {
            Venenosa = true;
        }
    }
}