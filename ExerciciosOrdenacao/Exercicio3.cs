using System;

namespace ExerciciosOrdenacao
{
    public class Exercicio3
    {
        static void Ordenar(string[] vetor)
        {
            int menor;
            string aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (CompararStrings(vetor[j], vetor[menor]) < 0)
                    {
                        menor = j;
                    }
                }

                aux = vetor[i];
                vetor[i] = vetor[menor];
                vetor[menor] = aux;
            }
        }

        static int CompararStrings(string str1, string str2)
        {
            int minLength = str1.Length < str2.Length ? str1.Length : str2.Length;
            for (int i = 0; i < minLength; i++)
            {
                if (str1[i] != str2[i])
                {
                    return str1[i] - str2[i];
                }
            }
            return str1.Length - str2.Length;
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
            Ordenar(vetor);
            Imprimir(vetor);
        }
    }
}