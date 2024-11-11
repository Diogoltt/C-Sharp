namespace Aula6;

class Exercicio2 {
    static void teste() {
        int[] vetor = new int[10];
        int maior = int.MinValue;
        int menor = int.MaxValue;
            
        for (int i = 0; i < vetor.Length; i++) {
            System.Console.WriteLine($"Digite o valor {i} do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < vetor.Length; i++) {
            if (vetor[i] > maior) {
                maior = vetor[i];
            }

            if (vetor[i] < menor) {
                menor = vetor[i];
            }
        }

        System.Console.WriteLine("O maior valor do vetor é: " + maior);
        System.Console.WriteLine("O menor valor do vetor é: " + menor);
    }
}