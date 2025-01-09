using Exercicio_BankAccount.Exceptions;

namespace Exercicio_BankAccount
{
    public class Customer
    {
        public Customer(int customerID, string name, DateTime dob, int pin)
        {
            CustomerID = customerID;
            Name = name;
            DOB = dob;
            PIN = pin;
            Accounts = new List<Account>();
        }

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public List<Account> Accounts { get; set; }
        private int PIN { get; set; }

        public bool VerifyPassword(int pin)
        {
            if (pin != PIN)
            {
                throw new SenhaIncorretaException("Não foi possível acessar a conta, a senha está incorreta.");
            }
            return true;
        }
    }
}