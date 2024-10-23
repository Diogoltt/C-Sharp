using System;
using System.Security.Cryptography.X509Certificates;
namespace Exemplo {
    internal class Program {
        static void Main(String[] x) {
            int idade = 25;
            double saldo = 10.50;
            string nome = "Maria Conceição";

            //Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos de idade e um saldo de R$" + saldo);
            
            //Console.WriteLine("{0} tem {1} anos de idade e tem um saldo igual a {2:f2} reais", nome, idade, saldo);
            
            Console.WriteLine($"{nome} tem {idade} anos de idade e tem um saldo igual a {saldo:f2} reais");
        }
    }
}