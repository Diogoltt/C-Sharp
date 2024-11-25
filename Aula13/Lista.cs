namespace Aula13;

public class Lista
{
    static int[] vetor = new int[10];
    
    // Metódo inserir
    static void Inserir(int valor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == 0)
            {
                vetor[i] = valor;
                break;
            }
        }
    }

    static void Remover(int valor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                vetor[i] = 0;
                break;
            }
        }
    }

    static void Listar()
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] != 0)
            {
                Console.Write(vetor[i] + " ");
            }
        }
    }

    static void ListarInverso()
    {
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            if (vetor[i] != 0)
            {
                Console.WriteLine(vetor[i] + " ");   
            }
        }
    }

    static void teste()
    {
        Inserir(10);
        Inserir(20);
        Inserir(30);
        Inserir(40);
        Inserir(50);
        Inserir(60);
        Inserir(70);
        Inserir(80);
        Console.WriteLine("Lista: ");
        Listar();
        Console.WriteLine("\nLista invertida: ");
        ListarInverso();
        Console.WriteLine("Remover: 50");
        Remover(50);
        Listar();
    }
}