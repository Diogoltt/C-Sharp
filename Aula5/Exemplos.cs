using System;
namespace Aula5 {
    class Exemplos {
        static void teste() {
            
            int[] vetor = new int[10];
            
            Random r = new Random();

            for(int i = 0; i < vetor.Length; i++) {
                vetor[i] = r.Next(1, 100);
            }

            System.Console.WriteLine("Ordem direta");
            for(int i = 0; i < 10; i++) {
                System.Console.WriteLine($"{vetor[i]}");
            }



        }
    }   
}