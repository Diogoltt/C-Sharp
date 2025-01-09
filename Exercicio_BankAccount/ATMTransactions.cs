namespace Exercicio_BankAccount
{
    public class ATMTransactions
    {
        public ATMTransactions(int transactionID, TransactionType type, double amount, double postBalance)
        {
            TransactionID = transactionID;
            Type = type;
            Amount = amount;
            PostBalance = postBalance;
            Date = DateTime.Now;
        }

        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public double Amount { get; set; }
        public double PostBalance { get; set; }

        public override string ToString()
        {
            return $"ID: {TransactionID}, Data: {Date}, Tipo: {Type}, "
            + $"Valor: {Amount}, Saldo Final {PostBalance}";
        }
    }
}