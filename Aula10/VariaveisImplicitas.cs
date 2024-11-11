using System;
namespace Aula10 {
    public class VariaveisImplicitas {
        static void teste() {
            var nome = "C#";
            System.Console.WriteLine(nome);
            System.Console.WriteLine(nome.GetType());
        
            var peso = 50;
            System.Console.WriteLine(peso);
            System.Console.WriteLine(peso.GetType());

            var altura = 1.60;
            System.Console.WriteLine(altura);
            System.Console.WriteLine(altura.GetType());

            const double pi = 3.145;
            System.Console.WriteLine(pi);
            System.Console.WriteLine(pi.GetType());

            var lista = new List<int> {1, 2, 3, 4, 5};

            foreach (var item in lista) 
            {
                System.Console.WriteLine(item);
            }

            var dicionario = new Dictionary<string, int>
            {
                {"C#", 1},
                {"Java", 2},
                {"Python", 3}
            };
            System.Console.WriteLine(dicionario.GetType());

            foreach(var item in dicionario)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}