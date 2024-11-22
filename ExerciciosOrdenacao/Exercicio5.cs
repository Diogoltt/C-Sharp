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

        static void OrdenarMerge(int[] vetor)
        {
            if (vetor.Length <= 1)
                return;

            int meio = vetor.Length / 2;
            int[] esquerda = new int[meio];
            int[] direita = new int[vetor.Length - meio];

            Array.Copy(vetor, esquerda, meio);
            Array.Copy(vetor, meio, direita, 0, vetor.Length - meio);

            OrdenarMerge(esquerda);
            OrdenarMerge(direita);

            Merge(vetor, esquerda, direita);
        }

        static void Merge(int[] vetor, int[] esquerda, int[] direita)
        {
            int i = 0, j = 0, k = 0;
            while (i < esquerda.Length && j < direita.Length)
            {
                if (esquerda[i] <= direita[j])
                    vetor[k++] = esquerda[i++];
                else
                    vetor[k++] = direita[j++];
            }

            while (i < esquerda.Length)
                vetor[k++] = esquerda[i++];

            while (j < direita.Length)
                vetor[k++] = direita[j++];
        }

        static void OrdenarQuick(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = Particionar(vetor, inicio, fim);
                OrdenarQuick(vetor, inicio, p - 1);
                OrdenarQuick(vetor, p + 1, fim);
            }
        }

        static int Particionar(int[] vetor, int inicio, int fim)
        {
            int pivo = vetor[fim];
            int i = inicio - 1;
            for (int j = inicio; j < fim; j++)
            {
                if (vetor[j] < pivo)
                {
                    i++;
                    int aux = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = aux;
                }
            }
            int temp = vetor[i + 1];
            vetor[i + 1] = vetor[fim];
            vetor[fim] = temp;
            return i + 1;
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
            int tamanho = 200000;
            int[] vetor = GerarArrayAleatorio(tamanho);
            int[] vetorBubble = (int[])vetor.Clone();
            int[] vetorInsertion = (int[])vetor.Clone();
            int[] vetorSelection = (int[])vetor.Clone();
            int[] vetorMerge = (int[])vetor.Clone();
            int[] vetorQuick = (int[])vetor.Clone();

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

            stopwatch.Restart();
            OrdenarMerge(vetorMerge);
            stopwatch.Stop();
            long tempoMerge = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Merge Sort: {tempoMerge} ms");

            stopwatch.Restart();
            OrdenarQuick(vetorQuick, 0, vetorQuick.Length - 1);
            stopwatch.Stop();
            long tempoQuick = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Quick Sort: {tempoQuick} ms");

            long menorTempo = Math.Min(tempoBubble, Math.Min(tempoInsertion, Math.Min(tempoSelection, Math.Min(tempoMerge, tempoQuick))));
            string melhorAlgoritmo = tempoBubble == menorTempo ? "Bubble Sort" :
                                      tempoInsertion == menorTempo ? "Insertion Sort" :
                                      tempoSelection == menorTempo ? "Selection Sort" :
                                      tempoMerge == menorTempo ? "Merge Sort" : "Quick Sort";
            Console.WriteLine($"Melhor desempenho: {melhorAlgoritmo}");
        }
    }
}
