using System;
namespace Aula14Exercicios
{
    public class ListaEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        private Node? inicio = null;

        public void Inserir(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = null };

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
            }
        }
        public void InserirValorNaPosicao(int valor, int posicao)
        {
            Node novoNode = new Node { valor = valor, proximo = null};

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                int i = 0;
                while (atual.proximo != null && i < posicao - 1)
                {
                    atual = atual.proximo;
                    i++;
                }
                novoNode.proximo = atual.proximo;
                atual.proximo = novoNode;
            }
        }

        public void Listar()
        {
            if (inicio == null)
            {
                System.Console.WriteLine("Lista vazia.");
            }

            Node? atual = inicio;
            System.Console.WriteLine("Elementos na lista: ");

            while (atual != null)
            {
                System.Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static void teste(string[] args)
        {
            ListaEncadeada lista = new ListaEncadeada();

            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Listar();
            lista.InserirValorNaPosicao(25, 1);
            lista.Listar();
        }

    }
}