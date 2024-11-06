using System;
namespace Aula8 {
    public class Modificadores {
        public int soma(int a, int b) {
            return a + b;
        }

        public int subtracao(int a, int b) {
            return a - b;
        }

        static void teste() {
            Modificadores m = new Modificadores();
            System.Console.WriteLine(m.soma(10, 20));

            System.Console.WriteLine(m.subtracao(50, 10));
        }
    }
}