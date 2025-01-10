/* namespace Aula25
{
    public struct PessoaStruct
    {
        public PessoaStruct(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }


    public class PessoaClasse
    {
        public PessoaClasse(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

    class Executar
    {
        public static void Main(string[] args)
        {
            var pessoaStruct1 = new PessoaStruct("João", 20);
            var pessoaStruct2 = pessoaStruct1;
            pessoaStruct2.Nome = "Maria";

            System.Console.WriteLine(pessoaStruct1);
            System.Console.WriteLine(pessoaStruct2);

            System.Console.WriteLine("----------------------");

            var pessoaClass1 = new PessoaClasse("João", 20);
            var pessoaClass2 = pessoaClass1;
            pessoaClass2.Nome = "Maria";

            System.Console.WriteLine(pessoaClass1);
            System.Console.WriteLine(pessoaClass2);

        }
    }
} */