using System;
namespace Aula14Exercicios
{
    public class Pilha
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
                System.Console.WriteLine("Pilha vazia");
            }

            System.Console.WriteLine($"Desempilhando {topo.valor}");
            topo = topo.proximo;
        }

        static void VerTopo()
        {
            if (topo == null)
            {
                System.Console.WriteLine("Pilha vazia");
            }

            System.Console.WriteLine($"O topo é {topo.valor}");
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

        static void teste(string[] args)
        {
        Empilhar(30); 
        Empilhar(20); 
        Empilhar(10);  
        Listar(); 
 
        VerTopo();
        }
    }
}