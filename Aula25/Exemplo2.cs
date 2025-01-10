namespace Aula25
{
    public struct ContaBancariaStruct
    {
        public ContaBancariaStruct(string numero, string titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }
        public void Saque(decimal valor)
        {
            if (Saldo >= valor)
                Saldo -= valor;
            else
                System.Console.WriteLine("Saldo insuficiente");
        }

        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo: {Saldo}";
        }

        public void AlterarSaldo(decimal valor)
        {
            this = new ContaBancariaStruct(this.Numero, this.Titular, valor + Saldo);
            System.Console.WriteLine("Saldo alterado com sucesso");
        }
    }

    public class ContaBancariaClasse
    {
        public ContaBancariaClasse(string numero, string titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }
        public void Saque(decimal valor)
        {
            if (Saldo >= valor)
                Saldo -= valor;
            else
                System.Console.WriteLine("Saldo insuficiente");
        }
        public void AlterarSaldo(decimal valor)
        {
            Saldo += valor;
            System.Console.WriteLine("Saldo alterado com sucesso");
        }
        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo: {Saldo}";
        }
    }

    class Exe
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaBancariaStruct("123", "Maria", 1000);
            conta1.AlterarSaldo(200);
            System.Console.WriteLine(conta1);

            var conta2 = new ContaBancariaClasse("123", "Maria", 1000);
            conta2.AlterarSaldo(200);
            System.Console.WriteLine(conta2);

        }
    }

}