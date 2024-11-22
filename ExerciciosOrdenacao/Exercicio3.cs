using System;

namespace ExerciciosOrdenacao
{
    public class Exercicio3
    {
        static void SelectionSort(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int menorIndice = i;
                for (int j = i + 1; j < array.Length; j++)  // fix: start from i+1
                {
                    if (ehMenor(array[j], array[menorIndice]))
                    {
                        menorIndice = j;
                    }
                }

                string temp = array[i];
                array[i] = array[menorIndice];
                array[menorIndice] = temp;
            }
        }

        static bool ehMenor(string a, string b)
        {
            int tamanho = Math.Min(a.Length, b.Length);
            for (int i = 0; i < tamanho; i++)
            {
                if (a[i] < b[i])
                {
                    return true;
                }
                else if (a[i] > b[i])
                {
                    return false;
                }
            }

            return a.Length < b.Length;
        }

        static void Imprimir(string[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + ", ");
            }
            Console.WriteLine();
        }

        static string[] RecebeNomes()
        {
            Console.WriteLine("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());
            string[] vetor = new string[tamanho];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor para a posição {i} do vetor: ");
                vetor[i] = Console.ReadLine();
            }
            return vetor;
        }

        static void teste()
        {
            string[] vetor = RecebeNomes();
            SelectionSort(vetor); 
            Imprimir(vetor);
        }
    }
}
