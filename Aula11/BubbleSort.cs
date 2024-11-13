using System;

namespace Aula11
{
    public class BubbleSort
    {
        // Função para ordenar em ordem crescente
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

        static void teste()
        {
            int[] vetor = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            
            Ordenar(vetor);
            Imprimir(vetor);
        }
    }
}
