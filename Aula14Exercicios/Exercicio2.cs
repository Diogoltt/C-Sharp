using System;
namespace Aula14Exercicios
{
    public class ListaEncadeadaVerificar
    {
        class Node
        {
            public int Valor;      // Valor armazenado no nó
            public Node? Proximo;  // Referência para o próximo nó na lista encadeada
        }

        private Node? inicio = null;

        public void Inserir(int valor)
        {
            Node novoNode = new Node { Valor = valor, Proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novoNode;
            }
        }

        public void Excluir(int valor)
        {
            if (inicio == null) return;

            if (inicio.Valor == valor)
            {
                inicio = inicio.Proximo;
                return;
            }

            Node atual = inicio;
            while (atual.Proximo != null && atual.Proximo.Valor != valor)
            {
                atual = atual.Proximo;
            }

            if (atual.Proximo != null)
            {
                atual.Proximo = atual.Proximo.Proximo;
            }
        }

        public bool Contem(int valor)
        {
            Node? atual = inicio; 
            while (atual != null) 
            {
                if (atual.Valor == valor) 
                { 
                    return true;
                }
                atual = atual.Proximo;
            } return false;
        }

        public void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            Node? atual = inicio;
            Console.WriteLine("Elementos na lista:");

            while (atual != null)
            {
                Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }
        }

        static void teste(string[] args)
        {
            ListaEncadeadaVerificar lista = new ListaEncadeadaVerificar();
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            
            System.Console.WriteLine(lista.Contem(20));
            System.Console.WriteLine(lista.Contem(40));
        }
    }
}