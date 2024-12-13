using System.Reflection;

namespace Aula18
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Produto p = new("Bomba", 10000);
            p.Nome = "Bomba Nuclear";
            p.Preco = 20000;
            p.Quantidade = 10;

            System.Console.WriteLine("Nome: " + p.Nome);
            System.Console.WriteLine("Preço: " + p.Preco);
            System.Console.WriteLine("Quantidade: " + p.Quantidade);

            // System.Console.WriteLine(p.ToString());
        
            // Funcões p validar tipos e propriedades
            Type t = typeof(Produto);
            System.Console.WriteLine(t.Name);
        
            System.Console.WriteLine("Propriedades: ");
            foreach (PropertyInfo prop in t.GetProperties())
            {
                System.Console.WriteLine(prop.Name);
            }

        }
    }
}