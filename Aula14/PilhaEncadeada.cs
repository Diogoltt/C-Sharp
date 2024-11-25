namespace Aula14;

public class PilhaEncadeada
{
    class Node
    {
        public int valor;
        public Node? proximo;
    }

    static Node? topo = null;

    static void Empilhar(int valor)
    {
        Node novoNode = new Node {valor = valor, proximo = topo};
        
        topo = novoNode;
    }

    static void Desempilhar()
    {
        if (topo == null)
        {
            Console.WriteLine("Pilha vazia");
            return;
        }

        Console.WriteLine($"Desempilhando {topo.valor}");
        topo = topo.proximo;
    }

    static void Listar()
    {
        if (topo == null)
        {
            Console.WriteLine("Pilha vazia");
            return;
        }
        
        Console.WriteLine("Elementos na pilha:");
        Node? atual = topo;
        while (atual != null)
        {
            Console.WriteLine(atual.valor);
            atual = atual.proximo;
        }
    }

    static void teste()
    {
        Empilhar(1); 
        Empilhar(2); 
        Empilhar(3); 
        Empilhar(4); 
        Listar(); 
        Desempilhar(); 
        Listar();
    }
}