using System;

namespace ExerciciosOrdenacao
{
    public class Exercicio2
    {
        static void Ordenar(int[] vetor, ref int count)
        {
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1 - i; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux2 = vetor[j];
                        int aux3 = vetor[j + 1];
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        count++;
                        if (aux2 == vetor[j] && aux3 == vetor[j + 1])
                        {
                            break;
                        }
                    }
                }
            }
        }

        static void Imprimir(int[] vetor, int count)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Iterações: " + count);
        }

        static int[] RecebeValores()
        {
            Console.WriteLine("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[] vetor = new int[tamanho];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor para a posição {i} do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            return vetor;
        }

        static void teste()
        {
            int count = 0;
            int[] vetor = RecebeValores();
            Ordenar(vetor, ref count);
            Imprimir(vetor, count);
        }
    }
}