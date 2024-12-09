namespace Aula17Exercicio
{
    public class Comissionado : Empregado
    {
        public double TotalVenda;
        public double TaxaComissao;

        public Comissionado(string nome, string sobrenome, string cpf, double totalvenda, double taxacomissao) : base(nome, sobrenome, cpf)
        {
            TotalVenda = totalvenda;
            TaxaComissao = taxacomissao;
        }

        public override double Vencimento()
        {
            return TotalVenda * TaxaComissao;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            System.Console.WriteLine("Total Venda: " + TotalVenda);
            System.Console.WriteLine("Taxa de Comissão: " + TaxaComissao);
            System.Console.WriteLine("");
        }
    }
}