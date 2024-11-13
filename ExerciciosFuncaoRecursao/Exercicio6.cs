namespace ExerciciosFuncaoRecursao;

public class Exercicio6
{
    static int SomaVetor(int[] vetor, int n)
    {
        if (n < 0)
        {
            return 0;
        }
        else
        {
            return vetor[n] + SomaVetor(vetor, n - 1);
        }
    }

    static void teste()
    {
        int[] vetor = {1,2,3,4,5,6,7,8,9,10};

        int somaElementos = SomaVetor(vetor, vetor.Length - 1);
        double mediaElementos = (double)somaElementos / vetor.Length;
        Console.WriteLine($"A soma dos elementos do vetor é igual a: {somaElementos}");
        Console.WriteLine($"A média dos elementos do vetor é igual a: {mediaElementos}");
    }
}