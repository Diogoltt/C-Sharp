namespace ExerciciosOrdenacao
{
    public class Exercicio4
    {
        static void Ordenar(int[] vetor)
        {
            int aux, j;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;
                while (j >= 0 && vetor[j] < aux)
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
            int[] vetor = RecebeValores();
            Ordenar(vetor);
            Imprimir(vetor);
        }
    }
}