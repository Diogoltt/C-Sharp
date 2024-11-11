namespace Aula6;

class Exercicio3 {
    static void teste() {
            
        int maior = int.MaxValue;
        int menor = int.MinValue;

        int[,] matriz = new int[4,4];
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                System.Console.WriteLine($"Digite o valor da posição [{i},{j}] da matriz: ");
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        }


    }
}