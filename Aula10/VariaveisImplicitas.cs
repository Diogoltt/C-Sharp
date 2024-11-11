using System;
namespace Aula10 {
    public class VariaveisImplicitas {
        static void Main(string[] args) {
            var nome = "C#";
            System.Console.WriteLine(nome);
            System.Console.WriteLine(nome.GetType());
        
            var peso = 50;
            System.Console.WriteLine(peso);
            System.Console.WriteLine(peso.GetType());

            var altura = 1.60;
            System.Console.WriteLine(altura);
            System.Console.WriteLine(altura.GetType());
        }
    }
}