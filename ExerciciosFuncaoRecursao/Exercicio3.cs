namespace ExerciciosFuncaoRecursao;

public class Exercicio3
{
    static int potencia(int x, int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return x * potencia(x, n - 1);
        }
    }

    static void teste()
    {
        Console.WriteLine("Digite o número do parametro x: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número do parametro n: ");
        int n = int.Parse(Console.ReadLine());

        int calculaPotencia = potencia(x, n);
        Console.WriteLine($"A potencia de {x} elevado a {n} é igual a: {calculaPotencia}");
    }
}