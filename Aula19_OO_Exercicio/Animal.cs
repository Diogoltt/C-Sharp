namespace Aula19_OO_Exercicio
{
    public class Animal
    {
        protected int Pernas = 0;

        public Animal(int pernas)
        {
            Pernas = pernas;
        }

        public virtual void Caminha()
        {
            System.Console.WriteLine("O Animal está caminhando!");
        }

        public virtual void Come()
        {
            System.Console.WriteLine("O Animal está se alimentando!");
        }


    }
}