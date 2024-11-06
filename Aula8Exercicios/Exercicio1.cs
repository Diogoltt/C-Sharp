using System;
namespace Aula8Exercicios {
    public class Exercicio1 {
        
        public delegate double CalculaMedia(int[] valores);

        static double Media(int[] valores) {
            double media = 0;
            foreach (var valor in valores) {
                media += valor;
            }
            return media / valores.Length;
        }
        static void teste() {
            int[] vetor = new int[10];
            for (int i = 0; i < vetor.Length; i++) {
                System.Console.WriteLine($"Insira o valor {i}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            CalculaMedia cm = Media;
            double resultado = cm(vetor);
            System.Console.WriteLine($"A média dos valores digitados é: {resultado}");
        }


    }
}