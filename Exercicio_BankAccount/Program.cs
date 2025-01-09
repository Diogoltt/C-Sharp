using System;
using Exercicio_BankAccount;
using Exercicio_BankAccount.Exceptions;

namespace Exercicio_BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank();

            // EXEMPLO DE DADOS INICIAIS (clientes e contas criadas)
            // -----------------------------------------------------

            Customer cliente1 = new Customer(1, "Fulano da Silva", new DateTime(1990, 2, 2), 1234);
            bank.AddCustomer(cliente1);

            Customer cliente2 = new Customer(2, "Maria Souza", new DateTime(1988, 5, 10), 5678);
            bank.AddCustomer(cliente2);

            CurrentAccount contaCorrente1 = new CurrentAccount(1001, 500); 
            bank.AddAccount(contaCorrente1, 1);

            SavingAccount contaPoupanca1 = new SavingAccount(2001);
            bank.AddAccount(contaPoupanca1, 1);

            CurrentAccount contaCorrente2 = new CurrentAccount(3001, 700);
            bank.AddAccount(contaCorrente2, 2);

            contaCorrente1.Deposit(1500); 
            contaPoupanca1.Deposit(800);
            contaCorrente2.Deposit(1000);

            // MENU INTERATIVO
            // -----------------------------------------------------
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\n--- MENU PRINCIPAL ---");
                Console.WriteLine("1) Criar Novo Cliente");
                Console.WriteLine("2) Criar Nova Conta (Corrente ou Poupança)");
                Console.WriteLine("3) Realizar Depósito");
                Console.WriteLine("4) Realizar Saque");
                Console.WriteLine("5) Listar Todas as Contas");
                Console.WriteLine("6) Exibir Histórico de Transações de uma Conta");
                Console.WriteLine("7) Sair");

                Console.Write("Escolha uma opção: ");
                string opcaoEntrada = Console.ReadLine();
                Console.WriteLine();

                switch (opcaoEntrada)
                {
                    case "1":
                        CriarNovoCliente(bank);
                        break;

                    case "2":
                        CriarNovaConta(bank);
                        break;

                    case "3":
                        RealizarDeposito(bank);
                        break;

                    case "4":
                        RealizarSaque(bank);
                        break;

                    case "5":
                        bank.ShowAllAccounts();
                        break;

                    case "6":
                        ExibirHistoricoTransacoes(bank);
                        break;

                    case "7":
                        sair = true;
                        Console.WriteLine("Saindo do sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        // MÉTODOS AUXILIARES DO MENU
        // -----------------------------------------------------

        /// Cria um novo cliente solicitando dados ao usuário.
        public static void CriarNovoCliente(Bank bank)
        {
            try
            {
                Console.Write("ID do novo cliente: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome do novo cliente: ");
                string nome = Console.ReadLine();

                Console.Write("Data de nascimento do novo cliente (dd/mm/aaaa): ");
                DateTime dataNasc = DateTime.Parse(Console.ReadLine());

                Console.Write("PIN (senha numérica) do novo cliente: ");
                int pin = int.Parse(Console.ReadLine());

                Customer novoCliente = new Customer(id, nome, dataNasc, pin);
                bank.AddCustomer(novoCliente);

                Console.WriteLine($"Cliente {nome} criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar cliente: " + ex.Message);
            }
        }

        /// Cria uma nova conta (Corrente ou Poupança) e a associa a um cliente existente.
        public static void CriarNovaConta(Bank bank)
        {
            try
            {
                Console.Write("ID do cliente para associar a conta: ");
                int clienteID = int.Parse(Console.ReadLine());

                Console.Write("Digite o número da nova conta: ");
                int numeroConta = int.Parse(Console.ReadLine());

                Console.WriteLine("Tipo de conta: ");
                Console.WriteLine("1) Conta Corrente");
                Console.WriteLine("2) Conta Poupança");
                Console.Write("Escolha: ");
                string tipoConta = Console.ReadLine();

                Account novaConta;
                if (tipoConta == "1")
                {
                    Console.Write("Digite o limite de saque/cheque especial: ");
                    double limite = double.Parse(Console.ReadLine());
                    novaConta = new CurrentAccount(numeroConta, limite);
                }
                else
                {
                    novaConta = new SavingAccount(numeroConta);
                }

                bank.AddAccount(novaConta, clienteID);
                Console.WriteLine($"Conta {numeroConta} criada e associada ao cliente {clienteID} com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar conta: " + ex.Message);
            }
        }

        /// Solicita ao usuário a conta de destino e o valor para depositar.
        public static void RealizarDeposito(Bank bank)
        {
            try
            {
                Console.Write("Número da conta para depósito: ");
                int numeroConta = int.Parse(Console.ReadLine());

                Console.Write("Valor do depósito: ");
                double valor = double.Parse(Console.ReadLine());

                ATM atm = new ATM(bank);
                atm.RealizarDeposito(numeroConta, valor);

                Console.WriteLine("Depósito realizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao realizar depósito: " + ex.Message);
            }
        }

        /// Solicita ao usuário a conta de destino e o valor para saque.
        public static void RealizarSaque(Bank bank)
        {
            try
            {
                Console.Write("Número da conta para saque: ");
                int numeroConta = int.Parse(Console.ReadLine());

                Console.Write("Valor do saque: ");
                double valor = double.Parse(Console.ReadLine());

                ATM atm = new ATM(bank);
                atm.RealizarSaque(numeroConta, valor);

                Console.WriteLine("Saque realizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao realizar saque: " + ex.Message);
            }
        }

        /// Solicita ao usuário uma conta e exibe o histórico de transações associadas.
        public static void ExibirHistoricoTransacoes(Bank bank)
        {
            try
            {
                Console.Write("Número da conta para exibir histórico: ");
                int numeroConta = int.Parse(Console.ReadLine());

                var conta = bank.FindAccountByNumber(numeroConta);
                if (conta != null)
                {
                    conta.ShowTransactions();
                }
                else
                {
                    Console.WriteLine("Conta não encontrada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao exibir histórico: " + ex.Message);
            }
        }
    }
}
