namespace ExercicioBiblioteca
{
    public class Executar
    {
        public static void Main()
        {
            Console.WriteLine("===== Sistema de Gerenciamento de Bibliotecas =====\n");

            // Criando a rede de bibliotecas
            var rede = new RedeBibliotecas();

            // Criando várias bibliotecas
            var bibliotecaUFMS = new Biblioteca("Biblioteca Central UFMS");
            var bibliotecaSaraiva = new Biblioteca("Biblioteca Saraiva");
            var bibliotecaCG = new Biblioteca("Biblioteca de Campo Grande");

            // Adicionando bibliotecas à rede
            rede.AdicionarBiblioteca(bibliotecaUFMS);
            rede.AdicionarBiblioteca(bibliotecaSaraiva);
            rede.AdicionarBiblioteca(bibliotecaCG);

            // Criando funcionários
            var bibliotecario1 = new Funcionario("João", "123.456.789-00", "Bibliotecário Chefe");
            var bibliotecario2 = new Funcionario("Maria", "234.567.890-00", "Bibliotecário");
            var assistente1 = new Funcionario("Pedro", "345.678.901-00", "Assistente de Biblioteca");
            var assistente2 = new Funcionario("Ana", "456.789.012-00", "Assistente de Biblioteca");

            // Criando leitores
            var leitor1 = new Leitor("Diogo", "987.654.321-00");
            var leitor2 = new Leitor("Carla", "876.543.210-00");
            var leitor3 = new Leitor("Lucas", "765.432.109-00");
            var leitor4 = new Leitor("Julia", "654.321.098-00");

            // Adicionando funcionários às bibliotecas
            Console.WriteLine("\n===== Alocação de Funcionários =====");
            bibliotecaUFMS.AdicionarFuncionario(bibliotecario1);
            bibliotecaUFMS.AdicionarFuncionario(assistente1);
            bibliotecaSaraiva.AdicionarFuncionario(bibliotecario2);
            bibliotecaCG.AdicionarFuncionario(assistente2);

            // Criando e adicionando livros
            Console.WriteLine("\n===== Cadastro de Livros =====");
            var livros = new List<Livro>
            {
                new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 5),
                new Livro("Dom Casmurro", "Machado de Assis", 1899, 3),
                new Livro("Clean Code", "Robert C. Martin", 2008, 2),
                new Livro("1984", "George Orwell", 1949, 4),
                new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 1943, 6),
                new Livro("Algoritmos", "Thomas H. Cormen", 2009, 3)
            };

            // Distribuindo livros entre as bibliotecas
            foreach (var livro in livros.Take(3))
            {
                bibliotecaUFMS.AdicionarLivroAoCatalogo(bibliotecario1, livro);
            }

            foreach (var livro in livros.Skip(3).Take(2))
            {
                bibliotecaSaraiva.AdicionarLivroAoCatalogo(bibliotecario2, livro);
            }

            bibliotecaCG.AdicionarLivroAoCatalogo(assistente2, livros.Last());

            // Consultando livros em cada biblioteca
            Console.WriteLine("\n===== Consulta de Livros por Biblioteca =====");
            
            Console.WriteLine("\nLivros da Biblioteca UFMS:");
            leitor1.ConsultarLivros(bibliotecaUFMS);
            
            Console.WriteLine("\nLivros da Biblioteca Saraiva:");
            leitor2.ConsultarLivros(bibliotecaSaraiva);
            
            Console.WriteLine("\nLivros da Biblioteca de Campo Grande:");
            leitor3.ConsultarLivros(bibliotecaCG);

            // Realizando empréstimos
            Console.WriteLine("\n===== Realizando Empréstimos =====");
            bibliotecario1.RealizarEmprestimo(leitor1, livros[0]);
            Console.WriteLine();
            
            assistente1.RealizarEmprestimo(leitor2, livros[1]);    
            Console.WriteLine();
            
            bibliotecario2.RealizarEmprestimo(leitor3, livros[3]); 
            Console.WriteLine();

            assistente2.RealizarEmprestimo(leitor4, livros[5]);

            // Verificando disponibilidade após empréstimos
            Console.WriteLine("\n===== Verificando Disponibilidade Após Empréstimos =====");
            Console.WriteLine("\nLivros da Biblioteca UFMS:");
            leitor1.ConsultarLivros(bibliotecaUFMS);
            
            Console.WriteLine("\nLivros da Biblioteca Saraiva:");
            leitor2.ConsultarLivros(bibliotecaSaraiva);
            
            Console.WriteLine("\nLivros da Biblioteca de Campo Grande:");
            leitor3.ConsultarLivros(bibliotecaCG);

            // Removendo um funcionário
            Console.WriteLine("\n===== Gerenciamento de Funcionários =====");
            bibliotecaUFMS.RemoverFuncionario(assistente1);

            // Removendo uma biblioteca da rede
            Console.WriteLine("\n===== Gerenciamento de Rede =====");
            rede.RemoverBiblioteca(bibliotecaCG);
            Console.WriteLine();
        }
    }
}