namespace ExerciciosFuncaoRecursao;

public class Exercicio4
{
    static int CalcularMDC(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return CalcularMDC(b, a % b);
        }
    }

    static void teste()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int b = int.Parse(Console.ReadLine());
            
            int mdc = CalcularMDC(a, b);
            Console.WriteLine($"o MDC de {a} e {b} é igual a: {mdc}");
        }
}
