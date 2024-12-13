namespace Aula18Exercicio
{
    public class Banco
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public Banco(int numeroConta, string nomeTitular, double depositoInicial = 0)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = depositoInicial > 0 ? depositoInicial : 0;
        }

        public void Deposito(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + NomeTitular
            + ", Saldo: $ " + Saldo.ToString("F2");
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Conta: {NumeroConta}");
            System.Console.WriteLine($"Titular: {NomeTitular}");
            System.Console.WriteLine($"Saldo: R${Saldo:F2}");
        }
    }
}
