namespace Aula19_OO_Exercicio
{
    public class Peixe : Animal, IAnimalDeEstimacao
    {

        private string _nome = "";
        
        public Peixe(int pernas) : base(pernas){}

        public Peixe(string nome) : base(0)
        {
            _nome = nome;
        }
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public void Brinca()
        {
            System.Console.WriteLine($"O Peixe está nadando!");
        }

        public override void Come()
        {
            System.Console.WriteLine($"O Peixe está comendo ração!");
        }

    }
}