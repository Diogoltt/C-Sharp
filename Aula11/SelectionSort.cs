namespace Aula11;

public class SelectionSort
{
    static void Ordenar(int[] vetor)
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
        Console.WriteLine(" ");
    }

    static void teste()
    {
        int[] vetor = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
        
        Ordenar(vetor);
        Imprimir(vetor);
    }
}