using System.Data;

namespace Desafio3_Padaria
{
    public class Venda
    {
        public Produto[] Produtos { get; set; }
        public DataSetDateTime Data { get; set; }
        public Vendedor Vendedor { get; set; }
        public string FormaPagamento { get; set; }
        public int Parcelas { get; set; }
        public double ValorTotal { get; set; }
        public Cliente Cliente { get; set; }

        public double CalcularValorFinal()
        {
            Imposto imposto = new Imposto();
            double valorFinal = 0;
            foreach (var produto in Produtos)
            {
                valorFinal += produto.CalculaPrecoFinal();
            }
            return valorFinal - imposto.CalcularImpostoVendas();
        }
    }
}