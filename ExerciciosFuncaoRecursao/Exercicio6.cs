namespace ExerciciosFuncaoRecursao;

public class Exercicio6
{
    /*
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
    */

    static (int, double) SomaMediaVetor(int[] vetor, int index, int tamanho)
    {
        if (index < 0)
            return (0, 0.0);
        
        // Chamada recursiva
        (int somaParcial, double _) = SomaMediaVetor(vetor, index - 1, tamanho);
        int somaTotal = somaParcial + vetor[index];

        double media = (double)somaTotal / tamanho;
        
        return (somaTotal, media);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());
        int[] vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"Digite o elemento {i+1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        
        (int soma, double media) = SomaMediaVetor(vetor, tamanho - 1, tamanho);
        Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
        Console.WriteLine($"A média dos elementos do vetor é: {media}");
    }
    
    
}