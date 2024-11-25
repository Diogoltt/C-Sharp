namespace Aula13;

public class Fila
{
    private static int[] fila = new int[10];

    private static int inicio = 0;
    private static int fim = 0;
    
    static int count = 0;

    public static void Adicionar(int valor)
    {
        if (count < fila.Length)
        {
            fila[fim] = valor;
            fim = (fim + 1) % fila.Length;
            count++;
        }
        else
        {
            Console.WriteLine("Fila cheia!");
        }
    }

    public static void Remover()
    {
        if (count > 0)
        {
            fila[inicio] = 0;
            inicio = (inicio + 1) % fila.Length;
            count--;
        }
        else
        {
            Console.WriteLine("Fila vazia!");
        }
    }

    public static void Mostrar()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(fila[(inicio + i) % fila.Length]);
        }
    }

    public static void Primeiro()
    {
        if (count > 0)
        {
            Console.WriteLine(fila[inicio]);
        }
        else
        {
            Console.WriteLine("Fila vazia!");
        }
    }

    static void teste()
    {
        Adicionar(10);
        Adicionar(20);
        Adicionar(30);
        Adicionar(40);
        Adicionar(50);
        Adicionar(60);
        Adicionar(70);
        Adicionar(80);
        Adicionar(90);
        Adicionar(100);
        Mostrar();
        
        Console.WriteLine("Primeiro elemento da fila: ");
        Primeiro();

        Console.WriteLine("Fila com elemento removido: ");
        Remover();
        
        Mostrar();
        
    }
    
}