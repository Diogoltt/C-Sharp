namespace Aula18
{
    public class Produto
    {
        // private string? _nome;

        public string Nome { get; set; }

        private double _preco;        

        private int _quantidade;

        // Construtor padrão
        public Produto()
        {

        }

        // Construtor com 2 argumentos
        public Produto(string nome, double preco)
        {
            // _nome = nome;
            Nome = nome;
            _preco = preco;
        }

        // Reutilizando construtor dentro de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        /*
        public string? Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = Nome;
                }
            }
        }
        */

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        /*
        // Encapsulamento, que é Get(retornar) e Set(alterar) atributos privados
        public string? GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public void SetPreco(double preco)
        {
            if (preco > 0)
            {
                _preco = preco;
            }
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }
        */

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        // Função para calcular valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        // Função ToString

        public override string ToString()
        {
            return Nome + ", $" + _preco.ToString("F2") +
            ", " + _quantidade + " unidades, Total: $ " 
            + ValorTotalEmEstoque().ToString("F2");
        }

    }
}