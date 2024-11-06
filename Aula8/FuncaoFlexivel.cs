using System;
namespace Aula8 {
    public class FuncaoFlexivel {
        public delegate int Operacao(int a, int b);

        static int Soma(int a, int b) => a + b;

        public delegate void Notificar();
        public static void EnviarEmail() => System.Console.WriteLine("Email enviado.");

        public static void EnviarSMS() => System.Console.WriteLine("SMS enviado.");

        static void Main(string[] args) {
            Operacao op = Soma;
            System.Console.WriteLine(op(1,2));

            Operacao op2 = (int a, int b) => a * b;
            System.Console.WriteLine(op2(3, 2));

            //Func<int, int, int> op3 = delegate(int a, int b)

            Notificar notificar = EnviarEmail;
            notificar += EnviarSMS;
            notificar();
            System.Console.WriteLine(notificar);
        }
    }
}