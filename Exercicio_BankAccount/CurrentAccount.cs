using Exercicio_BankAccount.Exceptions;

namespace Exercicio_BankAccount
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(int number, double withdrawLimit) 
        : base(number)
        {
            WithdrawLimit = withdrawLimit;
        }
        public double WithdrawLimit { get; set; }

        public override void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ValorInvalidoException("O valor de saque deve ser maior que zero.");
            }

            if (Balance + WithdrawLimit < amount)
            {
                throw new SaldoInsuficienteException("O valor de saque não pode ser maior que o saldo + limite de saque da conta.");
            }

            Balance -= amount;
            CreateTransaction(TransactionType.Withdraw, amount, Balance);
        }

        

    }
}