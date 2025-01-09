namespace Exercicio_BankAccount.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string message) 
        : base(message)
        {

        }
    }
}