using System;

namespace Aula10 {
    class reff
    {
        static int Quadrado(int x)
        {
            return x * x;
        }    
        
        static int QuadradoRef(ref int x)
        {
            return x = x * x;
        }
        
        static int QuadradoOut(out int x)
        {
            x = 6;
            return x * x;
        }

        static void teste()
        {
            int a = 10;
            Console.WriteLine(Quadrado(a)); // Imprime o quadrado de 'a' mas não altera 'a'
            Console.WriteLine(a); // Imprime o valor original de 'a' que é 10

            QuadradoRef(ref a); // Altera o valor de 'a' para o seu quadrado
            Console.WriteLine(a); // Agora 'a' será 100

            int b;
            int resultadoOut = QuadradoOut(out b); // Define 'b' como 6 e calcula seu quadrado
            Console.WriteLine(b); // Imprime 6, que é o valor atribuído dentro de QuadradoOut
            Console.WriteLine(resultadoOut); // Imprime 36, que é o quadrado de 6
        }
    }
}
