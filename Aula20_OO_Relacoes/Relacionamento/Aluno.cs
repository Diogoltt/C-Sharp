namespace Aula20_OO_Relacoes
{
    public class Aluno
    {
        public string Nome { get; set; }
        public Aluno(string nome)
        {
            Nome = nome;
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"O nome do aluno é: {Nome}");
        }

    }
}