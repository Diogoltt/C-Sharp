using System;
namespace Aula14
{
    public class ListaDuplamenteEncadeada
    {
        class Node{
            public int valor;
            public Node? proximo;
            public Node? anterior;
        }

        static Node? inicio = null;

        static void Inserir(int valor)
        {
            Node novoNode = new Node {valor = valor, proximo = null, anterior = null};
            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while (atual.proximo != null)
                {
                    atual = atual.proximo;
                }
                atual.proximo = novoNode;
                novoNode.anterior = atual;
            }
        }

        static void Excluir(int valor)
        {
            if (inicio == null)
            {
                System.Console.WriteLine("Lista vazia");
                return;
            }
          //  if (inicio.valor == valor)
          //  {
          //      inicio = inicio.proximo;
          //      inicio.anterior = null;
          //      return;
          //  }
           if (inicio.valor == valor)
           {
                if (inicio.proximo != null)
                {
                    inicio.proximo.anterior = null;
                }
                inicio = inicio.proximo;
                return;
           }

           Node atual = inicio;
           while (atual != null && atual.valor != valor)
           {
                atual = atual.proximo;
           }

           if (atual != null)
           {
                if (atual.anterior != null)
                {
                    atual.anterior.proximo = atual.proximo;
                }
                
                if (atual.proximo != null)
                {
                    atual.proximo.anterior = atual.anterior;
                }
           }
        }

        static void Listar()
        {
            Node? atual = inicio;
            while (atual != null)
            {
                System.Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }
        
        static void teste(string[] args)
        {
            Inserir(10);
            Inserir(20); 
            Inserir(30); 
            Console.WriteLine("Lista após inserção:"); 
            Listar(); 
            
            Excluir(20); 
            Console.WriteLine("Lista após exclusão:");
            Listar();
        }
    }
}

