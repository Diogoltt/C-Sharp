namespace Aula19_OO_Relacoes
{
    public class Professor
    {
        public string? Nome;

        public Professor(string nome)
        {
            Nome = nome;
        }

        public void Ensinar()
        {
            System.Console.WriteLine($"Professor {Nome} está dando aula");
        }
    }
}