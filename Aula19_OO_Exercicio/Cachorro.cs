namespace Aula19_OO_Exercicio
{
    public class Cachorro : Animal, IAnimalDeEstimacao
    {

        private string? _nome;

        public Cachorro(int pernas) : base(pernas){}

        public Cachorro(string nome) : base(5)
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
            System.Console.WriteLine($"O cachorro está brincando com a bola");
        }

        public override void Come()
        {
            System.Console.WriteLine($"O Cachorro está comendo");
        }
    }
}