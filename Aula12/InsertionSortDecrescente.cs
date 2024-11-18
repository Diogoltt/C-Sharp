namespace Aula12
{
    public class InsertionSortDecrescente
    {
        static void Ordenar(int[] vetor)
        {
            int aux, j;
            for (int i = 0; i < vetor.Length; i++)
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

        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine(" ");
        }

        static void Main(string[] args)
        {
            int[] vetor = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11};

            Ordenar(vetor);
            Imprimir(vetor);
        }
    }
}