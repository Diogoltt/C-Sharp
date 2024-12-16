namespace Aula19_OO_Exercicio
{
    public class Formiga : Animal
    {
        public Formiga() : base(6)
        {}

        public override void Come()
        {
            System.Console.WriteLine("Formiga está comendo!");
        }
    }
}