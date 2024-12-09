namespace Aula17Exercicio2
{
    public abstract class Produto
    {
        
        private int codigo;
        private double preco;

        protected Produto(int codigo, double preco)
        {
            this.codigo = codigo;
            this.preco = preco;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        } 

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public abstract void AtualizaPreco(double preco);

    }
}