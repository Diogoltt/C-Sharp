using System;
namespace ExerciciosFuncaoRecursao {
    class Exercicio1 {
        static int Soma(int n) {
            if (n == 1) 
            {
                return 1;
            }
            else 
            {
                return n + Soma(n - 1);
            }
        }

        static void teste()
        {
            int num = int.Parse(Console.ReadLine());

            int soma = Soma(num);

            System.Console.WriteLine($"A soma dos números de 1 a {num} é: {soma}");
        }
    }
}