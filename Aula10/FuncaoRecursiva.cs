using System;

namespace Aula10
{
    public class FuncaoRecursiva
    {
        
        // Os pares de um vetor com recursão
        static int Impares(int[] vetor, int n)
        {
            if (n == 0)
                return 0;
            else if (vetor[n - 1] % 2 == 1)
                return vetor[n - 1] + Impares(vetor, n - 1);
            else
                return Impares(vetor, n - 1);
        }
        
        // Função recursiva que calcula o fatorial de um número
        static int Fatorial(int n)
        {
            if (n == 0)
                return 1; 
            else
                return n * Fatorial(n - 1); 
        }

        // Função recursiva que calcula o número de Fibonacci
        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0; 
            else if (n == 1)
                return 1; 
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        // Função iterativa para calcular Fibonacci
        static int Fibonacci2(int n)
        {
            int a = 0, b = 1, c = 1;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }

        static void teste()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O Fatorial de " + numero + " é " + Fatorial(numero));
            Console.WriteLine("O Fibonacci recursivo de " + numero + " é " + Fibonacci(numero));
            Console.WriteLine("O Fibonacci iterativo de " + numero + " é " + Fibonacci2(numero));
            
            // Chamar a função par
            int[] vetor = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("A soma dos impares do vetor são: " + Impares(vetor, vetor.Length));
        }
    }
}