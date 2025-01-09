using Exercicio_BankAccount.Exceptions;

namespace Exercicio_BankAccount
{
    public class ATM
    {
        public ATM(Bank bankRefference)
        {
            BankRefference = bankRefference;
        }

        public Bank BankRefference { get; set; }

        public void RealizarDeposito(int number, double value)
        {
            var account = BankRefference.FindAccountByNumber(number);
            if (account == null)
            {
                throw new ContaNaoEncontradaException("A conta não foi encontrada para depósito.");
            }

            account.Deposit(value);
        }

        public void RealizarSaque(int number, double value)
        {
            var account = BankRefference.FindAccountByNumber(number);
            if (account == null)
            {
                throw new ContaNaoEncontradaException("A conta não foi encontrada para realizar o saque.");
            }
            
            account.Withdraw(value);
        }
    }
}