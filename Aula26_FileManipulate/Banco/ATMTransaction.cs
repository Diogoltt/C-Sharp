namespace Aula26_FileManipulate.Banco
{
    public class ATMTransaction
    {
        public string Tipo { get; private set; }
        public double Valor { get; private set; }

        public ATMTransaction(string tipo, double valor)
        {
            Tipo = tipo;
            Valor = valor;
        }
    }
}