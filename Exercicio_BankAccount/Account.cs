using Exercicio_BankAccount.Exceptions;

namespace Exercicio_BankAccount
{
    public abstract class Account
    {
        public Account(int number)
        {
            Number = number;
            Transactions = new List<ATMTransactions>();
            Balance = 0;
        }

        public int Number { get; set; }
        public double Balance { get; set; }
        public List<ATMTransactions> Transactions { get; set; }
        

        public virtual void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ValorInvalidoException("O valor depositado deve ser maior que zero.");
            }

            Balance += amount;
            CreateTransaction(TransactionType.Deposit, amount, Balance);
        }

        public virtual void Withdraw(double amount)
        {
            if (Balance < 0)
            {
                throw new SaldoInsuficienteException("O saldo da conta está negativo, não é possível realizar o saque");
            }

            if (Balance < amount)
            {
                throw new SaldoInsuficienteException("O valor do saque não pode exceder o saldo disponível na conta");
            }

            Balance -= amount;
            CreateTransaction(TransactionType.Withdraw, amount, Balance);

        }

        public void CreateTransaction(TransactionType type, double amount, double postBalance)
        {
            int transactionID = Transactions.Count + 1;

            var transaction = new ATMTransactions(transactionID, type, amount, postBalance);
            Transactions.Add(transaction);
        }

        public void ShowTransactions()
        {
            System.Console.WriteLine($"Histórico de transações da conta {Number}: ");
            foreach (var transacao in Transactions)
            {
                System.Console.WriteLine(transacao);
            }
        }
    }
}