using System;

namespace Aula3 {
    class CalculadoraFinanceira {
        static void Main(string[] args) {
            System.Console.WriteLine("Digite o valor que deseja investir: ");
            double valorInicial = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Agora digite o tipo de investimento (1 - Poupança, 2 - Renda fixa, 3 - Ações): ");
            int tipoInvestimento = int.Parse(Console.ReadLine());

            double taxaRendimento = 0;
            bool risco = false;

            switch (tipoInvestimento) {
                case 1:
                    taxaRendimento = 0.03;
                    break;
                case 2:
                    taxaRendimento = 0.05; 
                    break;
                case 3:
                    taxaRendimento = 0.10; 
                    risco = true; 
                    break;
                default:
                    System.Console.WriteLine("Tipo de investimento Inválido!");
                    return; 
            }

            System.Console.WriteLine("Quantos anos deseja investir? ");
            int anos = int.Parse(Console.ReadLine());

            double valorFinal = valorInicial;

            Random random = new Random();

            for (int i = 1; i <= anos; i++) {
                if (tipoInvestimento != 3) {
                    valorFinal += valorFinal * taxaRendimento;
                }
                
                if (risco) {
                    double chancePerda = random.NextDouble();

                    if (chancePerda < 0.5) { 
                        valorFinal -= valorFinal * 0.05;
                        System.Console.WriteLine($"Houve uma perda de 5% ao investir em ações no ano {i}.");
                    } else {
                        valorFinal += valorFinal * taxaRendimento;
                    }
                }

                System.Console.WriteLine($"Valor no final do ano {i}: {valorFinal:F2}");
            }

            System.Console.WriteLine($"O valor final total foi de: {valorFinal:F2}");
        }
    }
}
