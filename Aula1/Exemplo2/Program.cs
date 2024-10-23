using System;
using System.Security.Cryptography.X509Certificates;
namespace Exemplo {
    internal class Program {
        static void Main() {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            String nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f; 

            Console.WriteLine($"Olá, {obj1}, você é do genero {genero} e tem {n1} anos");
    }
}
}