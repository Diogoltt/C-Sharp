namespace Aula13;

public class Pilha
{
    static int[] pilha = new int[10];
    
    static int topo = 0;

    public static void Push(int valor)
    {
        if (topo < pilha.Length)
        {
            pilha[topo] = valor;
            topo++;
        }
        else
        {
            Console.WriteLine("Pilha cheia!");
        }
    }

    public static void Pop()
    {
        if (topo > 0)
        {
            topo--;
            pilha[topo] = 0;
        }
        else
        {
            Console.WriteLine("Pilha vazia!");
        }
    }

    public static void Listar()
    {
        for (int i = topo - 1; i >= 0; i--)
        {
            Console.WriteLine(pilha[i]);
        }
    }

    static void Main(string[] args)
    {
        Push(10);
        Push(20);
        Push(30);
        Push(40);
        Push(50);
        Push(60);
        Push(70);
        Push(80);
        Push(90);
        Push(100);
        Listar();

        Console.WriteLine("Removendo um elemento da pilha: ");
        Pop();
        Listar();
    }
}