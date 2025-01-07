namespace ExerciciosEnumerate
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregados empresa = new Empregados();

            Vendedor v1 = new Vendedor(
                nome: "Diogo Leite", 
                salario: 1000.0, 
                licencasPremioRecebidas: 0,
                tipoEmpregado: TipoEmpregado.Vendedor,
                statusLicenca: StatusLicenca.Pendente,
                comissao: 0.1,
                regiao: RegiaoAtuacao.Sul
            );

            Vendedor v2 = new Vendedor(
                nome: "Lahra Vieira", 
                salario: 1200.0,
                licencasPremioRecebidas: 1,
                tipoEmpregado: TipoEmpregado.Vendedor,
                statusLicenca: StatusLicenca.Aprovada,
                comissao: 0.15,
                regiao: RegiaoAtuacao.Norte
            );

            GerenteVendas gv = new GerenteVendas(
                nome: "Carlos Oliveira",
                regiao: RegiaoAtuacao.Leste
            );
            gv.Salario = 3000.0;

            GerenteProducao gp = new GerenteProducao(
                nome: "Ana Pereira"
            );
            gp.Salario = 3500.0;

            empresa.Inserir(v1);
            empresa.Inserir(v2);
            empresa.Inserir(gv);
            empresa.Inserir(gp);

            Console.WriteLine("=== Lista de Todos os Empregados ===");
            empresa.Imprimir();

            Console.WriteLine("\n=== Demonstração de Funcionalidades ===");
            
            gv.Autorizar();
            gp.Autorizar();

            if(gv.AutorizaLicenca(v1))
            {
                v1.StatusLicenca = StatusLicenca.Aprovada;
                Console.WriteLine($"Licença de {v1.Nome} foi aprovada");
            }

            Console.WriteLine($"\nTotal da Folha de Pagamento: {empresa.FolhaPagamento():C}");
        }
    }
}
