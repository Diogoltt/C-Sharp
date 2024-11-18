using System;
using System.Diagnostics;

namespace ExerciciosOrdenacao
{
    public class Exercicio5
    {
        static void OrdenarBubble(int[] vetor)
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

        static void OrdenarInsertion(int[] vetor)
        {
            int aux, j;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;
                while (j >= 0 && vetor[j] > aux)
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }
                vetor[j + 1] = aux;
            }
        }

        static void OrdenarSelection(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }

                aux = vetor[i];
                vetor[i] = vetor[menor];
                vetor[menor] = aux;
            }
        }

        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] GerarArrayAleatorio(int tamanho)
        {
            Random random = new Random();
            int[] vetor = new int[tamanho];
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(0, 1000);
            }
            return vetor;
        }

        static void Main(string[] args)
        {
            int tamanho = 10000;
            int[] vetor = GerarArrayAleatorio(tamanho);
            int[] vetorBubble = (int[])vetor.Clone();
            int[] vetorInsertion = (int[])vetor.Clone();
            int[] vetorSelection = (int[])vetor.Clone();

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            OrdenarBubble(vetorBubble);
            stopwatch.Stop();
            long tempoBubble = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Bubble Sort: {tempoBubble} ms");

            stopwatch.Restart();
            OrdenarInsertion(vetorInsertion);
            stopwatch.Stop();
            long tempoInsertion = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Insertion Sort: {tempoInsertion} ms");

            stopwatch.Restart();
            OrdenarSelection(vetorSelection);
            stopwatch.Stop();
            long tempoSelection = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Selection Sort: {tempoSelection} ms");

            long menorTempo = Math.Min(tempoBubble, Math.Min(tempoInsertion, tempoSelection));
            string melhorAlgoritmo = tempoBubble == menorTempo ? "Bubble Sort" :
                                      tempoInsertion == menorTempo ? "Insertion Sort" : "Selection Sort";
            Console.WriteLine($"Melhor desempenho: {melhorAlgoritmo}");
        }
    }
}
