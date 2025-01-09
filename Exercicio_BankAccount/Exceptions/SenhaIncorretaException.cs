namespace Exercicio_BankAccount.Exceptions
{
    public class SenhaIncorretaException : Exception
    {
        public SenhaIncorretaException(string message)
        : base(message)
        {
            
        }
    }
}