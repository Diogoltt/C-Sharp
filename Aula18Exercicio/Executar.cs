using System;
using System.Globalization;

namespace Aula18Exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero da sua conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Banco conta;

            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Banco(numero, titular, depositoInicial);
            }
            else
            {
                conta = new Banco(numero, titular);
            }

            conta.ExibirDados();
            System.Console.WriteLine("");

            System.Console.WriteLine("Entre com o valor a ser depositado: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            System.Console.WriteLine("Dados atualizados da conta");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre com o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            System.Console.WriteLine(conta);

            /*
            Banco contaDiogo = new(12345, "Diogo");
            System.Console.WriteLine("");
            System.Console.WriteLine("Depositando 20 reais: ");
            contaDiogo.Deposito(20);
            contaDiogo.ExibirDados();
            
            System.Console.WriteLine("");
            System.Console.WriteLine("Sacando 40 reais (+R$5.00 de taxa): ");
            contaDiogo.Saque(40);
            contaDiogo.ExibirDados();

            System.Console.WriteLine("");
            System.Console.WriteLine("Trocando nome do titular: ");
            contaDiogo.NomeTitular = "Diogo Leite";
            contaDiogo.ExibirDados();

            System.Console.WriteLine("");
            System.Console.WriteLine("To String():");
            System.Console.WriteLine(contaDiogo.ToString());
            */
        }
    }
}

            