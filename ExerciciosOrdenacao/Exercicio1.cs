using System;

namespace ExerciciosOrdenacao
{
    public class Exercicio1
    {
        static void Ordenar(int[] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
        }
    
    
        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] RecebeValores()
        {
            Console.WriteLine("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[] vetor = new int[tamanho];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor para a posição {i} do vetor: : ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            return vetor;
        }

        static void teste()
        {
            int[] vetor = RecebeValores();
            Ordenar(vetor);
            Imprimir(vetor);
        }
    }
}