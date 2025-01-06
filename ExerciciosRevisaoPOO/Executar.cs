using ExerciciosRevisaoPOO.Exercicio1; // Alterar para .Exercicio2 ou .Exercicio1 para executá-los

namespace ExerciciosRevisaoPOO
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Exercicio 1 --------------------------------------------------------------
            System.Console.WriteLine("");
            System.Console.WriteLine("Homem: ");
            var homem = new HomoSapiens();
            System.Console.WriteLine(homem.ObterDescricao());

            System.Console.WriteLine("");
            System.Console.WriteLine("Cão: ");
            var cachorro = new CanisFamiliaris();
            System.Console.WriteLine(cachorro.ObterDescricao());

            System.Console.WriteLine("");
            System.Console.WriteLine("Mosca: ");
            var mosca = new MuscaDomestica();
            System.Console.WriteLine(mosca.ObterDescricao());



            // Exercicio 2 --------------------------------------------------------------
            /* var engenheiro = new Engenheiro("Astolfo Pires", "123.456.789-00", 123456);

            var predio = new Predio("Prédio Dom Quixote", 542.8f, "Rua da Paz, 135. Campo Grande-MS", engenheiro, 3, 1);

            predio.Unidades.Add(new UnidadeResidencial(80f, 3, 2, new Pessoa("Gilberto Macedo", "111.111.111-11")));
            predio.Unidades.Add(new UnidadeResidencial(80f, 3, 2, new Pessoa("Bruna Ruas", "222.222.222-22")));
            predio.Unidades.Add(new UnidadeResidencial(80f, 3, 2, new Pessoa("Vivian Bicalho", "333.333.333-33")));

            Console.WriteLine(predio.DescricaoDoImovel()); */



            // Exercicio 3 --------------------------------------------------------------
            /* var caminhao = new Caminhao("Volvo FH", 500, 100, 4);
            var moto = new Moto("Honda CG", 80, 20);
            var carroA = new CarroPasseio("Toyota Corolla", 200, 50, "A");
            var utilitario = new Utilitario("Fiat Ducato", 300, 70, true);

            Console.WriteLine(caminhao);
            Console.WriteLine($"Valor da Diária: R$ {caminhao.CalculaValorDiaria():F2}\n");

            Console.WriteLine(moto);
            Console.WriteLine($"Valor da Diária: R$ {moto.CalculaValorDiaria():F2}\n");

            Console.WriteLine(carroA);
            Console.WriteLine($"Valor da Diária: R$ {carroA.CalculaValorDiaria():F2}\n");

            Console.WriteLine(utilitario);
            Console.WriteLine($"Valor da Diária: R$ {utilitario.CalculaValorDiaria():F2}\n"); */
        }
    }
}