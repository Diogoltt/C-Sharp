namespace Exercicio_BankAccount
{
    public class Bank
    {
        public Bank()
        {
            Customers = new List<Customer>();
            Accounts = new List<Account>();
        }

        public List<Customer> Customers { get; set; }
        public List<Account> Accounts { get; set; }
        
        public void AddCustomer(Customer cliente)
        {
            Customers.Add(cliente);
        }

        public void AddAccount(Account account, int customerID)
        {
            var customer = Customers.Find(c => c.CustomerID == customerID);
            if (customer == null)
            {
                throw new Exception("Cliente não encontrada para adicionar a conta. ");
            }

            customer.Accounts.Add(account);
            Accounts.Add(account);
        }

        public Account FindAccountByNumber(int number)
        {
            return Accounts.Find(c => c.Number == number);
        }

        public void ShowAllAccounts()
        {
            System.Console.WriteLine("Lista de todas as contas neste banco: ");
            foreach(var account in Accounts)
            {
                System.Console.WriteLine($"Conta número: {account.Number}");
                System.Console.WriteLine($"Saldo: {account.Balance}");
            }
        }

    }
}