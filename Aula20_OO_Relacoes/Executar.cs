namespace Aula20_OO_Relacoes
{
    public class Executar
    {
        static void Main(string[] args)
        {
            /* Escola escola = new Escola("João");

            Professor professor = new Professor("Maria");

            escola.ContratarProfessor(professor);

            escola.MostrarInfo(); */

            /* System.Console.WriteLine("Herança");
            PortaCozinha portaCozinha = new("Branca", 1.5, 2.5, 10);
            portaCozinha.Abrir();
            portaCozinha.Fechar();
            System.Console.WriteLine($"Porta Cozinha: Cor: {portaCozinha.Cor} | Altura: {portaCozinha.Altura} | Largura: {portaCozinha.Largura} | Peso: {portaCozinha.Peso}");
            System.Console.WriteLine();

            System.Console.WriteLine("Agregação");
            //Cozinha cozinha = new Cozinha(true, 20);
            //cozinha.PortaCozinha.Abrir();
            System.Console.WriteLine();

            System.Console.WriteLine("Composição");
            PortaQuarto portaQuarto = new("Marrom", 0.80, 2.00, 15.0);
            Quarto quarto = new Quarto(true, 20);
            System.Console.WriteLine($"Quarto: {quarto.PortaQuarto.Cor}");
            System.Console.WriteLine();
            
            System.Console.WriteLine("Associação simples");
            PortaSala portaSala = new("Azul", 1.5, 2.5, 10);
            Sala sala = new(portaSala, portaQuarto, 20);
            sala.AbrirPortaAuxiliar(); */

            // Criando um Estado
            Estado estado = new Estado("São Paulo", "SP");

            // Criando uma Cidade
            Cidade cidade = new Cidade("São Paulo", estado);

            // Criando um Endereco
            Endereco endereco = new Endereco("Av. Paulista", 123, "Bela Vista", "01310-000", cidade);

            // Criando uma Equipe de Vendas
            EquipeVenda equipeVenda = new EquipeVenda("Equipe Alpha");

            // Criando um Vendedor
            Vendedor vendedor = new Vendedor("Carlos", new DateTime(1990, 5, 15), "123.456.789-00", endereco, equipeVenda);

            // Criando um Gerente
            Gerente gerente = new Gerente("Ana", new DateTime(1985, 3, 20), "987.654.321-00", endereco);

            // Exibindo informações
            Console.WriteLine("Vendedor:");
            Console.WriteLine($"Nome: {vendedor.GetNome()}");
            Console.WriteLine($"Nascimento: {vendedor.GetNascimento():dd/MM/yyyy}");
            Console.WriteLine($"Equipe: {vendedor.Equipe.Nome}");
            Console.WriteLine($"Salário: R$ {vendedor.GetSalario()}");
            Console.WriteLine($"Endereço: {vendedor.Endereco.Rua}, {vendedor.Endereco.Numero}, {vendedor.Endereco.Bairro}, {vendedor.Endereco.Cidade.Nome}, {vendedor.Endereco.Cidade.Estado.Sigla}, {vendedor.Endereco.CEP}");
            Console.WriteLine("");
            
            Console.WriteLine("\nGerente:");
            Console.WriteLine($"Nome: {gerente.GetNome()}");
            gerente.GetSalario();
        }
    }
}