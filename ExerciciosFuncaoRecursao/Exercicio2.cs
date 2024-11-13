namespace ExerciciosFuncaoRecursao;

public class Exercicio2
{
    static int produto(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * produto(n - 1);
        }
    }

    static void teste()
    {
        Console.WriteLine("Digite o número que deseja calcular o produto: ");
        int num = int.Parse(Console.ReadLine());

        int produtoNum = produto(num);

        Console.WriteLine($"O produto de 1 até {num} é: {produtoNum}");
    }
}